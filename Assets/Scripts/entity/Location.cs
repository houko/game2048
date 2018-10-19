using System;

namespace DefaultNamespace
{
    /// <summary>
    /// 位置
    /// </summary>
    internal struct Location
    {
        /// <summary>
        /// 行索引
        /// </summary>
        public int RIndex { get; set; }

        /// <summary>
        /// 列索引
        /// </summary>
        public int CIndex { get; set; }

        public Location(int r, int c) : this()
        {
            this.RIndex = r;
            this.CIndex = c;
        }
    }
}