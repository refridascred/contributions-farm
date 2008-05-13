using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample ^ seen) < (51 + sample))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = acc ^ (target * 4);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (target >= (62 + target))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }
    }
}
