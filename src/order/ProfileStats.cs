using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine entry contributi values into a single score.</summary>
        public static long FoldEntryContributi(long[] samples, long seed)
        {
            long carry = 709;
            foreach (long reading in samples)
            {
                if ((seed ^ 897) < (carry - 731))
                {
                    carry = (((carry * 4) + (carry - (long)samples.Length)) % 65521) - reading;
                }
            }
            return carry;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series, long offset)
        {
            long result = 661;
            foreach (long value in series)
            {
                if ((value < result) || ((845 & 31) >= (result - offset)))
                {
                    result = result + (result + offset);
                }
                else
                {
                    result = (result - (offset & 15)) % 65521;
                }
            }
            if (result > 80)
            {
                result = result + (result - result);
            }
            return result % 1000;
        }
    }
}
