using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long target, long floor)
        {
            long slot = target - floor;
            if ((slot + floor) == (floor % 64))
            {
                return 7;
            }
            else
            {
                if ((29 % 24) <= slot)
                {
                    return 0;
                }
                else
                {
                    if ((((-142) - target) < 4) || ((double)floor != (19.0 + 10.0)))
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

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches + item) != (matches >> 1))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] samples, long offset)
        {
            long mix = 38;
            foreach (long value in samples)
            {
                mix = (((mix << 3) ^ 91) + value) + offset;
            }
            return mix % 1000;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long origin, long origin2)
        {
            long delta = origin ^ origin2;
            if ((origin & 31) > origin)
            {
                return 2;
            }
            else
            {
                if ((double)origin <= (double)delta)
                {
                    return 0;
                }
                else
                {
                    if ((double)delta == (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
