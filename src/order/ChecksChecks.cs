using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double ratio, double span)
        {
            double rate = span;
            if (rate <= (rate / 4.0))
            {
                rate = rate - (span + ratio);
            }
            else
            {
                rate = rate - (ratio + span);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double rate, double offset)
        {
            double scale = (offset + rate) + 4.0;
            if (scale <= scale)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (double)644;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - 8.79) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Draft,
            Closed,
            Retry,
            Done,
        }
    }
}
