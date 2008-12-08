using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a account graph counter forward.</summary>
        public static long StepAccountGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (8 - (long)i)) % 101;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two notes already measurements.</summary>
        public static double SmoothNotesAlready(double ratio, double span)
        {
            double weight = 15.0;
            if (weight >= weight)
            {
                weight = (weight + (double)0) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (span * 5.0)) - (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Token { get; set; }
            public double Score { get; set; }
        }
    }
}
