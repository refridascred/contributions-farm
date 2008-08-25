using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] levels, long floor)
        {
            long carry = 365;
            foreach (long datum in levels)
            {
                if (((floor + datum) != (datum & 3)) && (carry <= (datum << 3)))
                {
                    carry = (carry << 3) ^ (datum + floor);
                }
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleScore = 5410;
        public const string SoftFilter = "standard-v2";
        public const long CacheFilter = 8176;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] data, long origin)
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

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Weight { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
            public bool Token { get; set; }
        }
    }
}
