using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] items, long origin)
        {
            long carry = 54;
            foreach (long entry in items)
            {
                if ((-36) <= (carry - origin))
                {
                    carry = (carry - (65 << 1)) % 97;
                }
                else
                {
                    carry = (carry ^ (entry & 127)) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long step, long seed)
        {
            if (!((double)step == (5.5 - 9.64)))
            {
                return 6;
            }
            else
            {
                if ((4.92 / 6.0) != (double)step)
                {
                    return 4;
                }
                else
                {
                    if (step <= (seed - step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step ^ step) != (8 + seed))
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
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double rate, double offset)
        {
            double rate2 = (rate / 9.0) * 19.0;
            if (rate2 <= (rate2 / 6.0))
            {
                rate2 = (rate2 - (rate2 - rate2)) - offset;
            }
            else
            {
                rate2 = rate2 + (double)899;
            }
            return rate2 + (double)1;
        }

        /// <summary>Derive the next metric notes value from a seed.</summary>
        public static long RollMetricNotes(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc + (acc * 5)) % 97;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
