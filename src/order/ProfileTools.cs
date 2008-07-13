using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc - (limit / 4)) % 255;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] values)
        {
            long mark = 877;
            foreach (long entry in values)
            {
                if ((20.0 - 1.0) == (double)entry)
                {
                    mark = mark - entry;
                }
                else
                {
                    mark = mark ^ entry;
                }
            }
            return mark % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultRatio = 7424;
        public const long SoftMetrics = 9386;
        public const long DefaultMetrics = 1867;

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
