using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsDownloader.JsonModels
{
    public class CurseForgeSearchModInfoModel
    {
        public class Authors
        {
            /// <summary>
            /// 
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string url { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int projectId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string projectTitleId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string projectTitleTitle { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int userId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int twitchId { get; set; }
        }

        public class Attachments
        {
            /// <summary>
            /// 
            /// </summary>
            public int id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int projectId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string description { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public bool isDefault { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string thumbnailUrl { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string title { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string url { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int status { get; set; }
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
            /// <summary>
            /// 
            /// </summary>
            public int type { get; set; }
        }

        public class SortableGameVersion
        {
            /// <summary>
            /// 
            /// </summary>
            public string gameVersionPadded { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string gameVersion { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string gameVersionReleaseDate { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string gameVersionName { get; set; }
        }

        public class DependenciesModel
		{
            public int id { get; set; }
            public int addonId { get; set; }
            public int type { get; set; }
            public int fileId { get; set; }
        }

        public class LatestFiles
        {
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
            public List<DependenciesModel> dependencies { get; set; }
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
            public List<SortableGameVersion> sortableGameVersion { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string installMetadata { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string changelog { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public bool hasInstallScript { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public bool isCompatibleWithClient { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int categorySectionPackageType { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int restrictProjectFileAccess { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int projectStatus { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int renderCacheId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string fileLegacyMappingId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int projectId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string parentProjectFileId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string parentFileLegacyMappingId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string fileTypeId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string exposeAsAlternative { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public long packageFingerprintId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string gameVersionDateReleased { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int gameVersionMappingId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int gameVersionId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int gameId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public bool isServerPack { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string serverPackFileId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string gameVersionFlavor { get; set; }
        }

        public class Categories
        {
            /// <summary>
            /// 
            /// </summary>
            public int categoryId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string url { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string avatarUrl { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int parentId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int rootId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int projectId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int avatarId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int gameId { get; set; }
        }

        public class CategorySection
        {
            /// <summary>
            /// 
            /// </summary>
            public int id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int gameId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int packageType { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string path { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string initialInclusionPattern { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string extraIncludePattern { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int gameCategoryId { get; set; }
        }

        public class GameVersionLatestFiles
        {
            /// <summary>
            /// 
            /// </summary>
            public string gameVersion { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int projectFileId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string projectFileName { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int fileType { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int modLoader { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Authors> authors { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Attachments> attachments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string websiteUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int gameId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string summary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int defaultFileId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float downloadCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<LatestFiles> latestFiles { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Categories> categories { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int primaryCategoryId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public CategorySection categorySection { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string slug { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<GameVersionLatestFiles> gameVersionLatestFiles { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool isFeatured { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double popularityScore { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int gamePopularityRank { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string primaryLanguage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string gameSlug { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> modLoaders { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string gameName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string portalName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dateModified { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dateCreated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dateReleased { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool isAvailable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool isExperiemental { get; set; }
    }
}
