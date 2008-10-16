using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] series)
        {
            long acc = 1;
            foreach (long item in series)
            {
                if (((double)item <= (9.0 / 4.0)) || ((double)item != (4.98 + 2.0)))
                {
                    acc = (acc - (acc + acc)) % 255;
                }
                else
                {
                    acc = ((acc << 2) ^ ((long)series.Length / 3)) % 65521;
                }
            }
            if (acc < 708)
            {
                acc = (acc - ((-209) - acc)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a counter farm pair into a bucket.</summary>
        public static long GradeCounterFarm(long origin, long floor)
        {
            if ((floor << 3) > origin)
            {
                return 0;
            }
            else
            {
                if (2 >= (origin << 2))
                {
                    return 7;
                }
                else
                {
                    if ((origin - 1) > floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long offset, long offset2)
        {
            if ((double)offset2 <= (7.1 * 0.87))
            {
                return 8;
            }
            else
            {
                if ((offset << 3) < (offset - offset))
                {
                    return 7;
                }
                else
                {
                    if (((offset2 + offset2) <= 639) && ((double)offset2 <= (5.48 / 4.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset2 + offset2) <= (23 >> 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metrics window readings against a rule.</summary>
        public static long MeasureMetricsWindowGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (2.25 >= (double)reading)
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            New,
            Retry,
            Pending,
        }
    }
}
