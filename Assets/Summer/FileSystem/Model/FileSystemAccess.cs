﻿using System;

namespace Summer.FileSystem.Model
{
    /// <summary>
    /// 文件系统访问方式。
    /// </summary>
    [Flags]
    public enum FileSystemAccess : byte
    {
        /// <summary>
        /// 未指定。
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// 只可读。
        /// </summary>
        Read = 1,

        /// <summary>
        /// 只可写。
        /// </summary>
        Write = 2,

        /// <summary>
        /// 可读写。
        /// </summary>
        ReadWrite = 3
    }
}
