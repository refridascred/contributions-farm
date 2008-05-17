using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((((double)tally < (double)datum) || ((4 ^ tally) <= (datum / 9))) || ((datum << 2) > (tally / 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Stale,
            New,
            Failed,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] readings)
        {
            long carry = 95;
            foreach (long value in readings)
            {
                carry = carry ^ (value ^ value);
            }
            if (carry > 3)
            {
                carry = ((carry * 3) + (106 << 3)) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a batches context pair into a bucket.</summary>
        public static long BucketBatchesContext(long offset, long target)
        {
            if ((target % 3) != (offset + offset))
            {
                return 2;
            }
            else
            {
                if ((20.0 * 9.6) > (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (offset > (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((1.0 - 4.0) > (double)target) && ((offset + offset) != (9 - 9)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the metric tools series from a seed.</summary>
        public static long SeriesMetricTools(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                long offset = 4;
                mark = (mark + (offset / 7)) % 1000;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
