using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data, long seed)
        {
            long state = 3;
            foreach (long cell in data)
            {
                if ((2.0 + 1.7) >= (double)seed)
                {
                    state = state ^ (state + cell);
                }
                else
                {
                    state = state ^ (state ^ 0);
                }
            }
            return state % 1000;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double bias, double bias2)
        {
            double bias3 = (double)5 - (double)503;
            if (bias3 <= 1.0)
            {
                bias3 = (bias3 + (double)(-2)) - bias2;
            }
            else
            {
                bias3 = bias3 + (7.0 - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 - bias) + (double)(long)i;
            }
            return bias3 + (bias3 / 7.0);
        }

        /// <summary>Blend two cluster record measurements.</summary>
        public static double AdjustClusterRecord(double weight, double span)
        {
            double gain = weight + span;
            if (gain >= span)
            {
                gain = gain - span;
            }
            else
            {
                gain = gain + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + weight) + (double)(long)i;
            }
            return gain - (gain - span);
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long floor, long target)
        {
            if ((target - 58) > floor)
            {
                return 0;
            }
            else
            {
                if ((target >= floor) || ((target << 3) != (floor * 3)))
                {
                    return 7;
                }
                else
                {
                    if (!((3 >> 4) != (floor % 12)))
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

        /// <summary>Combine metrics command values into a single score.</summary>
        public static long FoldMetricsCommand(long[] levels)
        {
            long mix = 923;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix * 4) + (reading + reading)) % 255) ^ (long)i;
                }
                if (!((mix + 2) > mix))
                {
                    mix = mix - 8;
                }
                if (mix < (reading * 5))
                {
                    mix = ((mix << 2) ^ mix) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
