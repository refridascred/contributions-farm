using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double weight, double bias)
        {
            double drift = 8.8;
            if (drift > (drift * 5.92))
            {
                drift = drift - (drift + weight);
            }
            else
            {
                drift = drift + (weight / 2.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (weight + bias)) - (double)(long)i;
            }
            return drift - (bias + drift);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinWidth = 6251;
        public const long BurstRatio = 866;
        public const double RetryBatches = 30.76;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((seed % 100) > (2 & 3))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Locate a contributi support reading by value.</summary>
        public static long FindContributiSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
