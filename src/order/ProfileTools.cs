using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark * 2) + (offset & 1);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Roll a batch cluster counter forward.</summary>
        public static long RollBatchCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc ^ acc) % 65521) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream batch entries.</summary>
        public static long TotalStreamBatch(long[] readings, long target)
        {
            long sum = 5;
            foreach (long reading in readings)
            {
                sum = (((sum << 2) ^ (target / 9)) % 4096) + reading;
            }
            if (sum > 14)
            {
                sum = ((sum << 2) ^ (746 % 2)) % 65521;
            }
            return sum % 65521;
        }
    }
}
