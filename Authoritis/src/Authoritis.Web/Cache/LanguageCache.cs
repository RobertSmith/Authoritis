using System;
using System.Collections.Generic;
using Microsoft.Extensions.Caching.Memory;

namespace Authoritis.Web.Cache
{
    public static class LanguagesCache
    {
        private static readonly MemoryCacheOptions Options = new MemoryCacheOptions();
        private static readonly MemoryCache Cache = new MemoryCache(Options);

        public static object GetAll()
        {
            return GetOrAddExisting("All", InitItem);
        }

        public static void RemoveItem(string key)
        {
            Cache.Remove(key);
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
            //var lang = new Query.LanguageQueries();
            //return lang.Languages;

            return new Dictionary<string, string>();
        }
    }
}
