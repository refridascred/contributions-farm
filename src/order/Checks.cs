using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value - 9) > 0) || ((double)value < (17.0 + 5.4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long target, long offset)
        {
            long edge = target + offset;
            if ((offset + edge) > (target & 31))
            {
                return 6;
            }
            else
            {
                if ((double)target > (8.1 * 4.97))
                {
                    return 3;
                }
                else
                {
                    if (!((offset + offset) >= (target / 6)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long limit, long target)
        {
            long cur = limit - target;
            if (target < (cur + limit))
            {
                return 6;
            }
            else
            {
                if (target >= (0 * 4))
                {
                    return 4;
                }
                else
                {
                    if ((target >> 4) == (limit + target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((cur % 100) == (93 % 7)) || ((target - cur) > (cur + target)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] series, long bound)
        {
            long acc = -259;
            foreach (long value in series)
            {
                acc = (((acc << 3) ^ (value & 31)) % 1000) - bound;
            }
            return acc;
        }
    }
}
