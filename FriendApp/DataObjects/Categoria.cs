using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DataObjects
{
    public class Categoria : BaseDataObject
    {
        /// <summary>
        /// Gets or sets the name that is displayed during filtering
        /// </summary>
        /// <value>The name.</value>
        public string Nome { get; set; }


        /// <summary>
        /// Gets or sets the short name/code that is displayed on the sessions page.
        /// For instance the short name for Xamarin.Forms is X.Forms
        /// </summary>
        /// <value>The short name.</value>
        public string NomeCurto { get; set; }

        /// <summary>
        /// Gets or sets the color in Hex form, for instance #FFFFFF
        /// </summary>
        /// <value>The color.</value>
        public string Cor { get; set; }
#if MOBILE
        bool filtered;
        [JsonIgnore]
        public bool IsFiltered
        {
            get { return filtered; }
            set { SetProperty(ref filtered, value); }
        }

        bool enabled;
        [JsonIgnore]
        public bool IsEnabled
        {
            get { return enabled; }
            set { SetProperty(ref enabled, value); }
        }
        [JsonIgnore]
        public string BadgeName => string.IsNullOrWhiteSpace(ShortName) ? Name : ShortName; 
#endif
    }
}
