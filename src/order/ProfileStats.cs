using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((tally >> 2) <= tally) || ((6 << 1) < (datum + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double scale, double floor)
        {
            double bias = floor;
            if (bias >= (double)2)
            {
                bias = bias + (6.57 * 14.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + scale) + (double)(long)i;
            }
            return bias + scale;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Limit { get; set; } = "";
            public bool Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
