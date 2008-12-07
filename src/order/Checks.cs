using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count metrics cluster pairs that satisfy a relation.</summary>
        public static long OverlapMetricsClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Validate queue metrics readings against a bound.</summary>
        public static bool CheckQueueMetricsRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate layout command samples.</summary>
        public static long TallyLayoutCommand(long[] values, long target)
        {
            long anchor = 331;
            foreach (long item in values)
            {
                if ((target << 2) == (75 + anchor))
                {
                    continue;
                }
                else
                {
                    anchor = ((anchor - anchor) % 4096) ^ item;
                }
                if (((anchor / 6) >= target) || (anchor > (target << 1)))
                {
                    anchor = (anchor + (anchor + 14)) % 4096;
                }
            }
            if (anchor > 87)
            {
                anchor = (anchor * 5) + (target / 2);
            }
            return anchor;
        }

        /// <summary>Measure how many filter window samples are out of range.</summary>
        public static long TallyFilterWindowHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (6.0 * 2.4))
                {
                    matches = (matches + 2) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
