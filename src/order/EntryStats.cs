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

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long step, long seed)
        {
            if (!(step <= (seed ^ 9)))
            {
                return 6;
            }
            else
            {
                if ((723 + seed) < seed)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] data, long offset)
        {
            long sum = 752;
            foreach (long item in data)
            {
                if ((sum + offset) >= (145 % 8))
                {
                    sum = ((sum - 88) % 1000) - item;
                }
                if ((69 < sum) || ((offset / 2) >= ((long)data.Length * 4)))
                {
                    sum = (sum - (sum >> 2)) % 101;
                }
            }
            if (sum < 197)
            {
                sum = ((sum * 2) + (8 + offset)) % 4096;
            }
            return sum;
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
