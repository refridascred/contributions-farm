using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double weight, double offset)
        {
            double gain = weight;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (double)(long)i) - offset;
            }
            return gain + gain;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] readings)
        {
            long acc = 524;
            foreach (long datum in readings)
            {
                if ((6 * 4) <= acc)
                {
                    acc = (((acc << 2) ^ 4) % 255) + datum;
                }
                else
                {
                    acc = (acc - (acc + 15)) % 97;
                }
            }
            return acc;
        }
    }
}
