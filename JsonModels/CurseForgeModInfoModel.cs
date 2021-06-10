using ModsDownloader.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsDownloader.JsonModels
{
    public class CurseForgeModInfoModel
    {
        public class AuthorsItem
        {
            /// <summary>
            /// 作者名称
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// 作者链接
            /// </summary>
            public string url { get; set; }
            /// <summary>
            /// 此mod的id
            /// </summary>
            public int projectId { get; set; }
            /// <summary>
            /// ???
            /// </summary>
            public int id { get; set; }
            /// <summary>
            /// ???
            /// </summary>
            public string projectTitleId { get; set; }
            /// <summary>
            /// ???
            /// </summary>
            public string projectTitleTitle { get; set; }
            /// <summary>
            /// 用户id
            /// </summary>
            public int userId { get; set; }
            /// <summary>
            /// twitch的id
            /// </summary>
            public int twitchId { get; set; }
        }

        public class AttachmentsItem
        {
            /// <summary>
            /// 附件id
            /// </summary>
            public int id { get; set; }
            /// <summary>
            /// 此mod的id
            /// </summary>
            public int projectId { get; set; }
            /// <summary>
            /// 描述
            /// </summary>
            public string description { get; set; }
            /// <summary>
            /// 是否为默认
            /// </summary>
            public string isDefault { get; set; }
            /// <summary>
            /// 缩略图url
            /// </summary>
            public string thumbnailUrl { get; set; }
            /// <summary>
            /// 标题
            /// </summary>
            public string title { get; set; }
            /// <summary>
            /// 图的url
            /// </summary>
            public string url { get; set; }
            /// <summary>
            /// 状态
            /// </summary>
            public int status { get; set; }
        }

        public class ModulesItem
        {
            public string foldername { get; set; }
            public long fingerprint { get; set; }
            public int type { get; set; }
        }

        public class SortableGameVersionItem
        {
            /// <summary>
            /// 游戏版本格式化
            /// </summary>
            public string gameVersionPadded { get; set; }
            /// <summary>
            /// 游戏版本
            /// </summary>
            public string gameVersion { get; set; }
            /// <summary>
            /// 发布日期
            /// </summary>
            public string gameVersionReleaseDate { get; set; }
            /// <summary>
            /// 显示名称
            /// </summary>
            public string gameVersionName { get; set; }
        }

        public class LatestFilesItem
        {
            /// <summary>
            /// 
            /// </summary>
            public int id { get; set; }
            /// <summary>
            /// 显示名称
            /// </summary>
            public string displayName { get; set; }
            /// <summary>
            /// 文件名称
            /// </summary>
            public string fileName { get; set; }
            /// <summary>
            /// 文件发布日期
            /// </summary>
            [JsonConverter(typeof(CurseForgeDateFormat))] public DateTime fileDate { get; set; }
            /// <summary>
            /// 文件长度
            /// </summary>
            public int fileLength { get; set; }
            /// <summary>
            /// 稳定版类型
            /// </summary>
            public int releaseType { get; set; }
            /// <summary>
            /// 文件状态
            /// </summary>
            public int fileStatus { get; set; }
            /// <summary>
            /// 下载链接
            /// </summary>
            public string downloadUrl { get; set; }
            /// <summary>
            /// 备用的
            /// </summary>
            public string isAlternate { get; set; }
            /// <summary>
            /// 备用文件id
            /// </summary>
            public int alternateFileId { get; set; }
            /// <summary>
            /// 依赖
            /// </summary>
            public List<DependenciesModel> dependencies { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string isAvailable { get; set; }
            /// <summary>
            /// 模块？
            /// </summary>
            public List<ModulesItem> modules { get; set; }
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
            public List<SortableGameVersionItem> sortableGameVersion { get; set; }
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
            public string hasInstallScript { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string isCompatibleWithClient { get; set; }
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
            public string isServerPack { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string serverPackFileId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string gameVersionFlavor { get; set; }
        }

        public class CategoriesItem
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

        public class GameVersionLatestFilesItem
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
        }

        public class DependenciesModel
        {
            public int id { get; set; }
            public int addonId { get; set; }
            public int type { get; set; }
            public int fileId { get; set; }
        }

        /// <summary>
        /// mod的id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// mod显示名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        public List<AuthorsItem> authors { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        public List<AttachmentsItem> attachments { get; set; }
        /// <summary>
        /// 网页url
        /// </summary>
        public string websiteUrl { get; set; }
        /// <summary>
        /// 游戏id(mc为432)
        /// </summary>
        public int gameId { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string summary { get; set; }
        /// <summary>
        /// 默认文件id
        /// </summary>
        public int defaultFileId { get; set; }
        /// <summary>
        /// 下载数量
        /// </summary>
        public float downloadCount { get; set; }
        /// <summary>
        /// 最新的文件
        /// </summary>
        public List<LatestFilesItem> latestFiles { get; set; }
        /// <summary>
        /// 分类
        /// </summary>
        public List<CategoriesItem> categories { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 初级分类id
        /// </summary>
        public int primaryCategoryId { get; set; }
        /// <summary>
        /// 分类?
        /// </summary>
        public CategorySection categorySection { get; set; }
        /// <summary>
        /// 真实名称(
        /// </summary>
        public string slug { get; set; }
        /// <summary>
        /// 各游戏版本最新文件
        /// </summary>
        public List<GameVersionLatestFilesItem> gameVersionLatestFiles { get; set; }
        /// <summary>
        /// 特色？
        /// </summary>
        public string isFeatured { get; set; }
        /// <summary>
        /// 人气值
        /// </summary>
        public double popularityScore { get; set; }
        /// <summary>
        /// 游戏热度等级
        /// </summary>
        public int gamePopularityRank { get; set; }
        /// <summary>
        /// 语言
        /// </summary>
        public string primaryLanguage { get; set; }
        /// <summary>
        /// 游戏名
        /// </summary>
        public string gameSlug { get; set; }
        /// <summary>
        /// mod加载器
        /// </summary>
        public List<ModType> modLoaders { get; set; }
        /// <summary>
        /// 游戏名称
        /// </summary>
        public string gameName { get; set; }
        /// <summary>
        /// 传送门名称
        /// </summary>
        public string portalName { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        [JsonConverter(typeof(CurseForgeDateFormat))] public DateTime dateModified { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        [JsonConverter(typeof(CurseForgeDateFormat))] public DateTime dateCreated { get; set; }
        /// <summary>
        /// 正式版日期
        /// </summary>
        [JsonConverter(typeof(CurseForgeDateFormat))] public DateTime dateReleased { get; set; }
        /// <summary>
        /// 是否可用
        /// </summary>
        public string isAvailable { get; set; }
        /// <summary>
        /// 实验版？
        /// </summary>
        public string isExperiemental { get; set; }
    }

}
