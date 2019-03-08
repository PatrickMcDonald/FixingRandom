namespace FixingRandom
{
    public interface IDistribution<T>
    {
        T Sample();
    }
}
