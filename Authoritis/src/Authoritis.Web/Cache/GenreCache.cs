using System;
using System.Collections.Generic;
using Microsoft.Extensions.Caching.Memory;

namespace Authoritis.Web.Cache
{
    public static class GenreCache
    {
        private static readonly MemoryCacheOptions Options = new MemoryCacheOptions(); 
        private static readonly MemoryCache Cache = new MemoryCache(Options);

        private static object GetAll()
        {
            return GetOrAddExisting("All", InitItem);
        }

        private static T GetOrAddExisting<T>(string key, Func<T> valueFactory)
        {
            var newValue = new Lazy<T>(valueFactory);
            var oldValue = Cache.Get(key) as Lazy<T>;

            try
            {
                if (oldValue == null)
                {
                    Cache.Set(key, newValue);
                    return newValue.Value;
                }

                return oldValue.Value;
            }
            catch
            {
                Cache.Remove(key);
                throw;
            }
        }

        private static object InitItem()
        {
            //var genre = new Query.GenreQueries();
            //return genre.Genres;
            return new Dictionary<string, string>();
        }
    }
}
