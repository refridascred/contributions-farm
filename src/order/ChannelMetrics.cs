using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell < (93 + step)) || !((cell & 63) >= (step / 5)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two filter stream measurements.</summary>
        public static double AdjustFilterStream(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 < bias2)
            {
                bias2 = (bias2 - 7.28) - bias;
            }
            else
            {
                bias2 = bias2 - floor;
            }
            return bias2 - (double)48;
        }
    }
}
