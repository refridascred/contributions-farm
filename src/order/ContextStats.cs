using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric checks readings.</summary>
        public static long WeighMetricChecks(long[] samples)
        {
            long acc = 70;
            foreach (long reading in samples)
            {
                if ((reading << 1) > acc)
                {
                    acc = acc - 862;
                }
                acc = ((acc << 3) ^ (reading >> 4)) % 101;
            }
            return acc;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count <= (double)count)
                {
                    count = ((count + 3) + sample) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
