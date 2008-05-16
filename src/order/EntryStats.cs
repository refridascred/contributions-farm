using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes batches values into a single score.</summary>
        public static long WeighNotesBatches(long[] data, long origin)
        {
            long acc = 8;
            foreach (long sample in data)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc << 3) ^ ((long)i2 * 3)) - origin;
                }
                acc = acc + ((-56) ^ sample);
            }
            if (acc > 299)
            {
                acc = acc + acc;
            }
            return acc % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 9588;
        public const double HardScore = 4.52;
        public const long CacheFactor = 485;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Stale,
            Ready,
            New,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long offset, long limit)
        {
            if (1.0 > (double)limit)
            {
                return 8;
            }
            else
            {
                if ((limit > (offset % 12)) && ((offset / 8) < limit))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit <= (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((7.88 + 8.0) != (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
