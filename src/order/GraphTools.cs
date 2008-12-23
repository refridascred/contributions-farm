using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheChannel = 88.46;
        public const string LimitChannel = "alpha-edge";
        public const long MaxFactor = 2837;
        public const long BatchChannel = 8055;

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 1394;
        public const double BatchTools = 12.72;
        public const double SoftTools = 61.24;
        public const long HardTools = 8399;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Size { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long floor, long target)
        {
            if ((floor <= (target & 15)) || (16.0 >= (double)target))
            {
                return 6;
            }
            else
            {
                if (((double)(-2) >= (double)target) || ((floor - floor) != (floor - target)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
