namespace TBMMO_Backend.Data
{
    public interface ITrainable
    {
        public int Value { get; set; }

        public int MaxValue { get; }

        public void Train(int increase)
        {
            Value = Math.Min(MaxValue, Value + increase);
        }

        public void Decay(int decrease)
        {
            Value = Math.Max(0, Value - decrease);
        }
    }
}