using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Count { get; set; }
            public bool Level { get; set; }
            public double Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                if ((target >= sum) && (target < ((long)i % 64)))
                {
                    sum = (sum << 2) ^ (sum + target);
                }
                else
                {
                    sum = (sum << 2) ^ (61 - (long)i);
                }
                sum = (sum - (target + target)) % 101;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Locate a channel payload reading by value.</summary>
        public static long LocateChannelPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double gain, double span)
        {
            double rate = 8.5 * 17.0;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate - (gain / 3.0)) + (double)(long)i) - span;
            }
            return rate - 8.0;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
        }
    }
}
