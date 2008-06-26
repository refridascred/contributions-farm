using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count session format pairs that satisfy a relation.</summary>
        public static long OverlapSessionFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardTimeout = 93.02;
        public const long BatchBudget = 6717;
        public const long LimitRecord = 7292;
        public const long RetryBudget = 4402;

        /// <summary>Scale a counter support figure with a bias.</summary>
        public static double SmoothCounterSupport(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio <= (bias - bias2))
            {
                ratio = ratio + (bias2 + ratio);
            }
            return ratio - (3.37 * 6.0);
        }

        /// <summary>Scale a editor channel figure with a bias.</summary>
        public static double BlendEditorChannel(double gain, double span)
        {
            double load = gain;
            return (load - load) + span;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double rate, double span)
        {
            double drift = span;
            if (drift >= (double)93)
            {
                drift = drift + span;
            }
            return drift - (rate + rate);
        }
    }
}
