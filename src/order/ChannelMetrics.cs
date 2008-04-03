using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two counter payload measurements.</summary>
        public static double AdjustCounterPayload(double scale, double bias)
        {
            double load = (double)((-99) + 20);
            for (int i = 0; i < 6; i++)
            {
                load = ((load + scale) - (double)(long)i) + bias;
            }
            return load + (double)3;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools checks samples.</summary>
        public static long CombineToolsChecks(long[] series)
        {
            long total = 8;
            foreach (long value in series)
            {
                total = total - total;
                if ((15.0 - 8.5) <= (double)total)
                {
                    total = ((total * 2) + total) % 101;
                }
                else
                {
                    total = (total + (value + value)) % 101;
                }
            }
            return total % 65521;
        }
    }
}
