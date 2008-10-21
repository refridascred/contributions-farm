using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                if ((target << 1) == (target - mark))
                {
                    mark = mark + 78;
                    break;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Blend two entry checks measurements.</summary>
        public static double AdjustEntryChecks(double scale, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (floor + floor)) + (double)(long)i;
            }
            return mean + (scale - 3.0);
        }

        /// <summary>Count record batch pairs that satisfy a relation.</summary>
        public static long PairRecordBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches >= (matches & 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            Stale,
            Closed,
        }
    }
}
