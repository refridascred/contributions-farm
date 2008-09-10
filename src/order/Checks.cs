using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double bias, double floor)
        {
            double rate = floor;
            if (rate <= (2.0 * 7.0))
            {
                rate = (rate - (double)197) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (double)271) + (double)(long)i;
            }
            return rate + (floor - floor);
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double rate, double floor)
        {
            double drift = rate;
            if (drift >= drift)
            {
                drift = drift - (rate / 4.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (floor - floor)) + (double)(long)i;
            }
            return drift - (double)208;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
