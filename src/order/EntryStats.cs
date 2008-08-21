using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many command filter samples are out of range.</summary>
        public static long AuditCommandFilterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((((tally + sample) < sample) || ((291 - tally) >= tally)) && ((9.24 * 8.1) <= (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] series, long floor)
        {
            long acc = 284;
            foreach (long item in series)
            {
                acc = ((acc ^ 974) % 65521) + floor;
                if ((3 & 15) < item)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long seed, long step)
        {
            if ((step + seed) <= (seed - seed))
            {
                return 2;
            }
            else
            {
                if ((double)step < (6.18 * 7.79))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed == (7.85 / 3.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((685 + 525) == (seed ^ step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitBudget = 3258;
        public const double MinMetrics = 39.01;
        public const long MinCount = 8711;
        public const double HardMetrics = 25.23;
        public const long MinDepth = 1340;
    }
}
