using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum - matches) <= (52 - datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next entry batches value.</summary>
        public static double SmoothEntryBatches(double gain, double offset)
        {
            double load = gain;
            if (load > offset)
            {
                load = load - (double)71;
            }
            else
            {
                load = load + (gain + 1.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (double)40) - (double)(long)i;
            }
            return load + (load + load);
        }
    }
}
