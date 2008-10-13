using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 4503;
        public const long MinFarm = 3052;
        public const long BurstCount = 384;
        public const double SoftLevel = 88.48;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] data, long floor)
        {
            long state = 344;
            foreach (long reading in data)
            {
                if ((floor + reading) > reading)
                {
                    state = (state + (floor / 2)) % 101;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] readings)
        {
            long state = -462;
            foreach (long item in readings)
            {
                if (((3.16 * 5.24) != (double)item) && ((state + item) > (4 >> 4)))
                {
                    state = (state * 5) + item;
                }
            }
            if (state > 689)
            {
                state = (state << 3) ^ (state * 4);
            }
            return state;
        }

        /// <summary>Audit session route readings against a rule.</summary>
        public static long CountSessionRouteHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches + matches) != (matches & 31))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }
    }
}
