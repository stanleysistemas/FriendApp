using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore.Abstractions
{
    public interface IStoreManager
    {
        bool IsInitialized { get; }
        Task InitializeAsync();
        ICategoriaStore CategoryStore { get; }
       // IFavoriteStore FavoriteStore { get; }
       // IFeedbackStore FeedbackStore { get; }
      //  ISessionStore SessionStore { get; }
      //  ISpeakerStore SpeakerStore { get; }
        IPatrocinadorStore SponsorStore { get; }
        IEventoStore EventStore { get; }
       // IMiniHacksStore MiniHacksStore { get; }
        INotificationStore NotificationStore { get; }

        Task<bool> SyncAllAsync(bool syncUserSpecific);
        Task DropEverythingAsync();
    }
}
