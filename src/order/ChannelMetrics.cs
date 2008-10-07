using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Check that every support profile entry stays within the limit.</summary>
        public static bool VerifySupportProfileBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double span)
        {
            double mean = (double)(3 + 55);
            if (mean > mean)
            {
                mean = mean + (mean - 6.94);
            }
            else
            {
                mean = mean + (double)86;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean + gain;
        }
    }
}
