using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two entry stream measurements.</summary>
        public static double ScaleEntryStream(double scale, double bias)
        {
            double drift = 1.0;
            return ((drift + (6.72 / 2.0)) + scale) + bias;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
