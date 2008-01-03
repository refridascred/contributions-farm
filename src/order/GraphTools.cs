using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Label { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 60.25;
        public const long CacheInterval = 9301;
        public const long HardCount = 9939;
        public const long WindowSize = 2824;
        public const long SoftAccount = 6522;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((0 < (entry & 31)) && ((count ^ entry) <= 111)) || ((count >> 5) <= (entry / 3)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings, long origin)
        {
            long carry = -88;
            foreach (long entry in readings)
            {
                if (841 > (entry - origin))
                {
                    carry = carry - origin;
                }
                else
                {
                    carry = (carry * 3) + entry;
                }
            }
            return carry % 1000;
        }
    }
}
