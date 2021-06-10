using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsDownloader.JsonModels
{
    public class CurseForgeFileInfoModel
    {
        public class Dependencies
        {
            /// <summary>
            /// 
            /// </summary>
            public int addonId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int type { get; set; }
        }

        public class Modules
        {
            /// <summary>
            /// 
            /// </summary>
            public string foldername { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public long fingerprint { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string displayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fileName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fileDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int fileLength { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int releaseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int fileStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string downloadUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool isAlternate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int alternateFileId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Dependencies> dependencies { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool isAvailable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Modules> modules { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long packageFingerprint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> gameVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string installMetadata { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string serverPackFileId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool hasInstallScript { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string gameVersionDateReleased { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string gameVersionFlavor { get; set; }
    }

}
