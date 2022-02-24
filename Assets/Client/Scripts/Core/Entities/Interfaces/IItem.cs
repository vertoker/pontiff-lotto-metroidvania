namespace Core.Entities.Interfaces
{
    public interface IItem
    {
        public Stats GetStats();
        public IPassiveEffect GetPassiveEffect();
    }
}