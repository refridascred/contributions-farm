using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a window batch value against two limits.</summary>
        public static long RankWindowBatch(long origin, long floor)
        {
            if ((9.6 + 9.5) <= (double)floor)
            {
                return 6;
            }
            else
            {
                if ((77 + origin) >= (floor / 7))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftCluster = 25.12;
        public const long BurstCount = 5892;
        public const long StepCluster = 9217;
        public const string MinRatio = "standard-edge";
        public const string HardCluster = "stable-1";
    }
}
