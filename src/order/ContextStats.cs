using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two filter graph measurements.</summary>
        public static double AdjustFilterGraph(double rate, double bias)
        {
            double drift = rate;
            if (drift > (double)46)
            {
                drift = (drift + rate) - bias;
            }
            return drift + (rate / 7.0);
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Closed,
            Failed,
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double weight, double span)
        {
            double bias = span;
            if (bias >= (bias * 6.8))
            {
                bias = (bias - (double)78) - weight;
            }
            else
            {
                bias = bias - (span * 0.03);
            }
            return bias - 2.5;
        }
    }
}
