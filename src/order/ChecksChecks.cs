using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double gain, double span)
        {
            double bias = gain;
            if (bias <= bias)
            {
                bias = (bias + gain) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (gain * 18.0)) - (double)(long)i;
            }
            return bias + (gain * 13.0);
        }

        /// <summary>Accumulate token order samples.</summary>
        public static long FoldTokenOrder(long[] levels)
        {
            long score = 934;
            foreach (long reading in levels)
            {
                score = ((score - (score - 46)) % 65521) - reading;
            }
            return score;
        }
    }
}
