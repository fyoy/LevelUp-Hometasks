namespace Lesson4
{
    internal class SimpleGenericCache<T>
    {
        private readonly Dictionary<string, CachedValue<T>> _cache = new();
        internal void Store(string key, T value, int timeout = 30)
        {
            var CachedValue = new CachedValue<T>
            {
                CreationTime = DateTime.Now,
                Timeout = timeout,
                Value = value
            };

            _cache[key] = CachedValue;
        }
        internal CachedValue<T>? Fetch(string key)
        {
            if (_cache.TryGetValue(key, out var value))
            {
                var timeCompare = value.CreationTime + TimeSpan.FromSeconds(value.Timeout);//Время + таймаут
                if(timeCompare >= DateTime.Now)
                {
                    return value;
                }
                else
                {
                    _cache.Remove(key);
                }
            }
            return default;
        }
    }
    internal record CachedValue<T>
    {
        public T? Value { get; init; }
        public DateTime CreationTime { get; init; } = DateTime.Now;
        public int Timeout { get; init; }
    }
}
