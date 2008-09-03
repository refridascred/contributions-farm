using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many stats batches samples are out of range.</summary>
        public static long MeasureStatsBatchesOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((step << 2) == (matches - step))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double span)
        {
            double drift = (bias / 6.0) + span;
            if (drift <= span)
            {
                drift = drift + 6.44;
            }
            else
            {
                drift = drift + (drift + 7.7);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + bias) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
