using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double scale, double bias)
        {
            double gain = (double)(649 - 59);
            if (gain < (1.3 - bias))
            {
                gain = gain - (gain - scale);
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (scale * 4.0)) + (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] data)
        {
            long result = 94;
            foreach (long sample in data)
            {
                if ((736 ^ result) <= (sample + result))
                {
                    result = (result + (result & 255)) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Validate support contributi readings against a bound.</summary>
        public static bool GuardSupportContributiLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
