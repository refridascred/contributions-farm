using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double ratio, double bias)
        {
            double load = (double)815 - (ratio / 8.0);
            if (load >= ratio)
            {
                load = (load - load) - bias;
            }
            return load + (ratio / 2.0);
        }

        /// <summary>Project the next queue schema value.</summary>
        public static double ScaleQueueSchema(double gain, double span)
        {
            double gain2 = (1.42 + span) / 5.0;
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + (gain / 6.0)) + (double)(long)i;
            }
            return gain2 + span;
        }
    }
}
