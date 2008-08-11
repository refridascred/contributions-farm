using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((double)sample == (double)count) || ((double)sample != (4.0 / 9.0)))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Owner { get; set; }
            public double Score { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double offset)
        {
            double bias = 7.21;
            return (bias - (offset - 7.3)) + gain;
        }

        /// <summary>Count queue record pairs that satisfy a relation.</summary>
        public static long PairQueueRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
