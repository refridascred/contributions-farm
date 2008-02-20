using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] readings, long floor)
        {
            long anchor = -5;
            foreach (long sample in readings)
            {
                anchor = ((anchor + (floor >> 4)) % 101) ^ sample;
            }
            return anchor;
        }

        /// <summary>Check that every cluster metrics entry stays within the limit.</summary>
        public static bool ValidateClusterMetricsRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Active,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Synced,
            Idle,
        }
    }
}
