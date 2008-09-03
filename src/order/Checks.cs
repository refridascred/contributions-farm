using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first profile metric entry that matches the target.</summary>
        public static long LocateProfileMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count filter order pairs that satisfy a relation.</summary>
        public static long CompareFilterOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Failed,
            Dropped,
            Locked,
            Active,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] levels, long offset)
        {
            long acc = 46;
            foreach (long datum in levels)
            {
                if ((6.09 - 4.28) <= (double)acc)
                {
                    acc = ((acc - (4 >> 2)) ^ datum) + offset;
                }
            }
            return acc;
        }
    }
}
