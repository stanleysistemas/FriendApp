﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class NivelPatrocinador : BaseDataObject
    {
        /// <summary>
        /// Gets or sets the name.
        /// Such as Platinum
        /// </summary>
        /// <value>The name.</value>
        public string Nome { get; set; }
        /// <summary>
        /// Gets or sets the rank.
        /// 0 means show this sponsor level at top
        /// </summary>
        /// <value>The rank.</value>
        public int Rank { get; set; }
    }
}
