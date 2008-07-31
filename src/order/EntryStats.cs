using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double MinSize = 52.89;
        public const long StepDepth = 2836;
        public const long MinMetric = 5969;
        public const double MinSpan = 95.04;
        public const long StepMetric = 2276;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(((sample % 60) >= (sample + 27)) || ((sample >> 2) <= (sample + sample))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double rate, double offset)
        {
            double ratio = (offset / 6.0) * 2.9;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio + (double)0;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
