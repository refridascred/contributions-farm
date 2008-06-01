using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((double)matches <= (6.9 * 1.1)))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = acc + (limit % 60);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples)
        {
            long sum = 53;
            foreach (long reading in samples)
            {
                if ((double)reading != (6.48 - 6.13))
                {
                    sum = ((sum * 4) + reading) % 65521;
                }
                if ((double)reading < 6.2)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
