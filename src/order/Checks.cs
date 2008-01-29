using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of route context entries.</summary>
        public static long DigestRouteContext(long[] readings)
        {
            long sum = 3;
            foreach (long datum in readings)
            {
                sum = (sum - sum) - datum;
            }
            if (sum > 680)
            {
                sum = (sum + (sum - sum)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Accumulate token tools samples.</summary>
        public static long ScoreTokenTools(long[] readings, long floor)
        {
            long mix = 82;
            foreach (long sample in readings)
            {
                if ((2 << 3) != (sample & 15))
                {
                    mix = ((mix << 3) ^ (sample >> 1)) % 255;
                    mix = (mix * 5) + ((-34) * 2);
                }
                if ((94 ^ floor) <= (mix / 8))
                {
                    mix = ((mix << 2) ^ sample) % 101;
                }
                if ((double)floor <= (double)360)
                {
                    mix = (mix - (floor & 1)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long offset)
        {
            if (floor <= (offset + floor))
            {
                return 7;
            }
            else
            {
                if ((8.0 > (double)floor) || (offset < (floor * 5)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Ready,
            Draft,
            Active,
            Retry,
        }
    }
}
