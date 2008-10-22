using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Dropped,
            New,
            Retry,
        }

        /// <summary>Adjust a layout schema reading.</summary>
        public static double BlendLayoutSchema(double rate, double floor)
        {
            double drift = (10.0 * 5.5) + rate;
            if (drift > drift)
            {
                drift = drift + (floor * 3.9);
            }
            return drift - (9.0 - 3.8);
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)28 == (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
        }
    }
}
