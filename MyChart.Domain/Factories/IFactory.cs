using MyChart.Domain.Common;

namespace MyChart.Domain.Factories
{
    public interface IFactory<out TEntity> where TEntity : IAggregateRoot
    {
        TEntity Build();
    }
}
