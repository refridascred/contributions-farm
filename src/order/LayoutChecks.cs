using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the cache format entries that pass the check.</summary>
        public static long TallyCacheFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry & 15) >= 11)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 6252;
        public const long MinNotes = 8399;
        public const long RetryDepth = 1683;

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = acc + ((long)i + acc);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings)
        {
            long score = 428;
            foreach (long sample in readings)
            {
                score = score - score;
                score = score ^ (sample - 8);
            }
            return score % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchBudget = 2323;
        public const long StepRatio = 3804;
        public const double StepAlready = 92.99;
        public const double BurstAlready = 27.23;
        public const long SoftAlready = 2888;

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
