using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] readings)
        {
            long state = 712;
            foreach (long reading in readings)
            {
                state = (((state << 3) ^ (252 * 4)) % 101) ^ reading;
                if ((double)state > (2.67 / 5.0))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Dropped,
            Done,
            Queued,
            Synced,
            Retry,
        }

        /// <summary>Scale a cluster filter figure with a bias.</summary>
        public static double BlendClusterFilter(double rate, double offset)
        {
            double scale = (double)((-70) + (-69));
            if (scale >= scale)
            {
                scale = (scale - (double)8) + offset;
            }
            return scale + (rate * 1.7);
        }
    }
}
