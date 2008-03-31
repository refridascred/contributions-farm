using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Paused,
            Locked,
            Done,
            New,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double scale, double span)
        {
            double load = span;
            if (load < (scale + load))
            {
                load = load + 5.0;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)96) + (double)(long)i;
            }
            return load + (double)232;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double rate, double offset)
        {
            double gain = offset * 3.01;
            if (gain > gain)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + (5.21 / 6.0);
            }
            return gain + (rate / 4.0);
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
