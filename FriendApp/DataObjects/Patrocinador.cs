using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    
    public class Patrocinador : BaseDataObject
    {
        /// <summary>
        /// Gets or sets the name of sponsor
        /// </summary>
        /// <value>The name.</value>
        public string Nome { get; set; }

        /// <summary>
        /// Gets or sets the sponsor level.
        /// </summary>
        /// <value>The sponsor level.</value>
        public virtual NivelPatrocinador SponsorLevel { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Descricao { get; set; }
        /// <summary>
        /// Transparent PNG Rectangle
        /// </summary>
        /// <value>The image URL.</value>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the website URL: http://www.xamarin.com
        /// </summary>
        /// <value>The website URL.</value>
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// Gets or sets the twitter profile: 
        /// </summary>
        /// <value>The twitter URL.</value>
        public string TwitterUrl { get; set; }

        /// <summary>
        /// Gets or sets the booth location.
        /// </summary>
        /// <value>The booth location.</value>
        public string BoothLocation { get; set; }

        /// <summary>
        /// Gets or sets the rank.
        /// 0 means put it at the top of the SponsorLevel
        /// </summary>
        /// <value>The rank.</value>
        public int Rank { get; set; }
#if MOBILE
        [Newtonsoft.Json.JsonIgnore]
        public Uri ImageUri 
        { 
            get 
            { 
                try
                {
                    return new Uri(ImageUrl);
                }
                catch
                {

                }
                return null;
            } 
        }
#endif
    }
}
