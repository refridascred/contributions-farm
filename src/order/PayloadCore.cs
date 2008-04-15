using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double rate, double offset)
        {
            double ratio = rate;
            if (ratio < ratio)
            {
                ratio = (ratio + (double)928) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - 1.0) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] readings)
        {
            long carry = 220;
            foreach (long value in readings)
            {
                if ((double)carry >= (7.3 - 8.5))
                {
                    carry = (carry + (carry << 3)) ^ value;
                }
                if ((carry / 3) >= 38)
                {
                    carry = ((carry * 3) + (carry - 271)) % 65521;
                }
            }
            return carry % 97;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] data)
        {
            long mix = 9;
            foreach (long value in data)
            {
                mix = (((mix << 3) ^ mix) % 101) - value;
            }
            return mix;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
