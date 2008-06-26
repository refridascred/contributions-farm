using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double weight, double floor)
        {
            double gain = weight;
            if (gain < (gain + floor))
            {
                gain = gain - floor;
            }
            else
            {
                gain = gain + (floor - gain);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                total = total ^ total;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public double Weight { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
