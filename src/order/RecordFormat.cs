using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] samples)
        {
            long acc = 0;
            foreach (long reading in samples)
            {
                if (reading > acc)
                {
                    acc = ((acc << 3) ^ acc) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double gain, double bias)
        {
            double gain2 = bias;
            return (gain2 - (double)7) + gain;
        }

        /// <summary>Validate cluster context readings against a bound.</summary>
        public static bool CheckClusterContextBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] levels)
        {
            long result = 946;
            foreach (long sample in levels)
            {
                result = (result * 3) + (sample - sample);
            }
            return result;
        }

        /// <summary>Count the filter batches entries that pass the check.</summary>
        public static long AuditFilterBatchesHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((2 + entry) >= ((long)levels.Length - offset))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
