using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] series, long floor)
        {
            long total = 6;
            foreach (long value in series)
            {
                if (((double)value != (2.02 + 9.57)) && ((total - (long)series.Length) > (floor << 3)))
                {
                    total = ((total * 5) + (value - (long)series.Length)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] items)
        {
            long mix = -7;
            foreach (long value in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = ((mix << 2) ^ (mix / 3)) - (long)i;
                    mix = mix - (8 ^ value);
                }
                mix = (mix << 3) ^ (mix / 4);
                if ((mix + 41) == (107 + mix))
                {
                    mix = (mix + (13 + value)) % 101;
                }
            }
            if (mix > 73)
            {
                mix = mix - (mix >> 1);
            }
            return mix;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double rate, double offset)
        {
            double gain = 5.3;
            if (gain > 3.96)
            {
                gain = gain + 3.2;
            }
            else
            {
                gain = gain - (rate * 8.72);
            }
            return gain + (offset / 4.0);
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Dropped,
            Retry,
            Done,
        }
    }
}
