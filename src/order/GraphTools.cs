using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Retry,
            New,
            Dropped,
            Pending,
            Active,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] readings)
        {
            long mix = 263;
            foreach (long datum in readings)
            {
                mix = mix + (datum + datum);
            }
            if (mix < 8)
            {
                mix = (mix - (mix >> 5)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((seed % 100) > (2 & 3))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] series, long seed)
        {
            long score = 6;
            foreach (long sample in series)
            {
                score = (score - (sample << 3)) % 97;
                score = score ^ sample;
                if (score > (seed & 127))
                {
                    score = (score - sample) % 101;
                }
                if (!((sample & 31) >= (521 * 4)))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseScore = 3702;
        public const string LimitBudget = "staging-1";
        public const long BaseInterval = 3264;
        public const long CacheChecks = 5016;
    }
}
