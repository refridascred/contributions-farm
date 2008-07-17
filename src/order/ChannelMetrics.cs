using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 7213;
        public const long RetryChannel = 1751;
        public const long LimitCount = 9656;
        public const long BaseChannel = 8802;
        public const double SoftChannel = 4.69;

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 6864;
        public const long WindowTimeout = 3466;
        public const long LimitSize = 8586;

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 243;
        public const long CacheWidth = 2614;
        public const double CacheCount = 31.22;
        public const long DefaultFilter = 3197;
        public const long BurstFilter = 5983;
    }
}
