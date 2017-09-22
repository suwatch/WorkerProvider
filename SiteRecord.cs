﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerProvider
{
    /// <summary>
    /// </summary>
    public class SiteRecord
    {
        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public string PoolId { get; set; }
        public string SiteMetadata { get; set; }
        public DateTime LastModifiedTimeUtc { get; set; }
    }
}
