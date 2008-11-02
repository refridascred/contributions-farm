using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
            public string Size { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultWidth = 9218;
        public const long IdleSchema = 9059;
        public const long CacheFactor = 9856;
        public const double BaseSchema = 49.34;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
