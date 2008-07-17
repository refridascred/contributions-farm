using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double gain, double span)
        {
            double load = 5.0 / 2.0;
            if (load < span)
            {
                load = (load + (double)310) + gain;
            }
            return load + load;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double rate = span;
            if (rate <= ratio)
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate + (span + span);
            }
            return rate - 5.0;
        }
    }
}
