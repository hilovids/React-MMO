using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Security.Cryptography;
using System.Text;
using TBMMO_Backend.Models;
using TBMMO_Backend.Models.PlayerCharacter;

namespace TBMMO_Backend.Controllers
{
    public class PCController : Controller
    {
        private AppDbContext db { get; set; }

        public PCController(AppDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public ActionResult<PlayerCharacter> Get(string username)
        {
            var player = db.Find<PlayerCharacter>(username);
            if(player == null)
            {
                return NotFound();
            }
            return player;
        }

        [HttpPost]
        public ActionResult<PlayerCharacter> Create(string username)
        {
            var player = new PlayerCharacter() { Name = username, LocationName = GetStartingLocation(), Salt = GenerateSalt() };
            db.PlayerCharacters.Add(player);
            db.SaveChanges();
            db.SkillSheets.Add(new SkillSheet() { PlayerCharacterName = player.Name });
            db.ProfessionSheets.Add(new ProfessionSheet() { PlayerCharacterName = player.Name });
            db.RelationshipSheets.Add(new RelationshipSheet() { PlayerCharacterName = player.Name });
            db.StatSheets.Add(new StatSheet() { PlayerCharacterName = player.Name });
            db.Clothing.Add(new Clothing() { PlayerCharacterName = player.Name });
            var inventory = new Inventory() { PlayerCharacterName = player.Name };
            db.Inventory.Add(inventory);
            db.SaveChanges();
            var startingBag = new Bag() { InventoryId = inventory.Id, Slots = 8};
            db.Bags.Add(startingBag);
            db.SaveChanges();
            return player;
        }

        [HttpPost]
        public ActionResult<PlayerCharacter> Register(PlayerCharacter player, string password)
        {
            if(player.Password == null)
            {
                return NotFound();
            }
            player.Password = ComputeHash(Encoding.UTF8.GetBytes(password), Encoding.UTF8.GetBytes(player.Salt));
            db.Add(player);
            db.SaveChanges();
            return player;
        }

        [HttpGet]
        public ActionResult<PlayerCharacter> Login(string username, string? password)
        {
            var player = db.PlayerCharacters.Find(username);
            // create a new character if none exists
            if (player == null)
            {
                return Create(username); 
            }
            // if the character is in the database without password
            if(player.Password == null)
            {
                return player;
            }
            // if the character is in the database with a password, but we didn't provide one, return incorrect password
            if(password == null)
            {
                return NotFound();
            }
            // if one exists and the password is correct, return that player
            if (player.Password == ComputeHash(Encoding.UTF8.GetBytes(password), Encoding.UTF8.GetBytes(player.Salt))) 
            {
                return player;
            }
            // if the password is incorrect and the player exists, return incorrect password view
            else
            {
                return NotFound(); 
            }
        }

        [HttpDelete]
        public ActionResult<PlayerCharacter> Delete(string username, string password)
        {
            var player = db.PlayerCharacters.Find(username);
            if (player != null && player.Password == ComputeHash(Encoding.UTF8.GetBytes(password), Encoding.UTF8.GetBytes(player.Salt)))
            {
                db.PlayerCharacters.Remove(player);
                db.SaveChanges();
            }
            return NotFound();
        }

        public static string GenerateSalt()
        {
            var bytes = new byte[128 / 8];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }

        public static string ComputeHash(byte[] bytesToHash, byte[] salt)
        {
            var byteResult = new Rfc2898DeriveBytes(bytesToHash, salt, 10000);
            return Convert.ToBase64String(byteResult.GetBytes(24));
        }

        public static string GetStartingLocation()
        {
            return "Twitter";
        }
    }
}
