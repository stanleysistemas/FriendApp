using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FriendApp.Helpers
{
    public static class ObservableExtensions
    {
        public static void AddRange<T>(this ObservableCollection<T> collection, IEnumerable<T> items)
        {
           // items.ToList().ForEach(collection.Add);

            foreach (var item in items)
            {
                collection.Add(item);
            }
        }
    }
}
