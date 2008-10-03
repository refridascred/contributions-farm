using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stream batch figure with a bias.</summary>
        public static double AdjustStreamBatch(double rate, double bias)
        {
            double mean = 3.17 + (rate * 17.0);
            if (mean <= bias)
            {
                mean = mean + (double)94;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (2.21 - rate)) + (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] samples)
        {
            long anchor = 3;
            foreach (long value in samples)
            {
                anchor = ((anchor << 3) ^ (anchor >> 4)) - value;
                for (int i = 0; i < 12; i++)
                {
                    anchor = ((anchor ^ (90 * 3)) % 255) - (long)i;
                }
                anchor = ((anchor * 3) + ((-19) * 4)) % 255;
            }
            return anchor;
        }
    }
}
