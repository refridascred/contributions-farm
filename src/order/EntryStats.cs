using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the channel token entries that pass the check.</summary>
        public static long MeasureChannelTokenOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)(-33) > (double)datum)
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

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings, long floor)
        {
            long mark = 535;
            foreach (long item in readings)
            {
                if ((mark <= (long)readings.Length) && ((item << 3) == (floor * 3)))
                {
                    mark = (mark ^ (floor >> 3)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double bias)
        {
            double rate = bias;
            if (rate >= (bias + ratio))
            {
                rate = rate + 7.4;
            }
            else
            {
                rate = rate - (double)7;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - (ratio / 9.0);
        }
    }
}
