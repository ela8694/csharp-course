using Generics;

namespace Test.Generics
{
    public class TestIRepository
    {
        private readonly MemoryRepository<string> _repository;

        public TestIRepository()
        {
            _repository = new MemoryRepository<string>();
        }

        [Fact]
        public void IRepository_ShouldAddAndGetValue()
        {
            _repository.Add("Item1");
            var result = _repository.Find(1);
            Assert.NotNull(result);
            Assert.Equal("Item1", result);
        }

        [Fact]
        public void Repository_GetInvalidId_ShouldReturnDefault()
        {
            var result = _repository.Find(1);
            Assert.Null(result);
        }
    }

    public class MemoryRepository<T> : IRepository<T>
    {
        private readonly Dictionary<int, T> _store = new();
        private int _counter = 0;

        public void Add(T entity)
        {
            _store[++_counter] = entity;
        }

        public T Find(int id)
        {
            return _store.TryGetValue(id, out var item) ? item : default;
        }
    }
}
