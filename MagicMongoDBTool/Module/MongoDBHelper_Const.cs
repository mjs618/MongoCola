﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicMongoDBTool.Module
{
    public static partial class MongoDBHelpler
    {
        //各种节点的Tag前缀
        /// <summary>
        /// 普通服务器Tag
        /// </summary>
        public const String ServiceTag = "MongoService";
        /// <summary>
        /// 该服务器只允许操作其下的某个数据库
        /// </summary>
        public const String SingleDBServiceTag = "MongoSingleDBService";

        public const String DataBaseTag = "MongoDatabase";
        public const String SingleDataBaseTag = "SingleMongoDatabase";

        
        public const String CollectionTag = "MongoCollection";
        public const String DocumentTag = "MongoDocument";
        public const String GridFileSystemTag = "MongoGFS";
        public const String UserListTag = "MongoUserList";
        public const String UserTag = "MongoUser";


        /// <summary>
        /// 路径阶层[考虑到以后可能阶层会变换]
        /// </summary>
        enum PathLv : int
        {
            ServerLV = 0,
            DatabaseLv = 1,
            CollectionLV = 2
        }


        public const String CollectionName_GridFileSystem = "fs.files";
        public const String CollectionName_User = "system.users";
        public const String CollectionName_JavaScript = "system.js";
    }
}
