using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] data)
        {
            long acc = 359;
            foreach (long sample in data)
            {
                if (((double)sample != (3.0 / 5.0)) || ((0 - 6) > (sample ^ acc)))
                {
                    acc = ((acc << 2) ^ (sample / 9)) % 97;
                }
                else
                {
                    acc = (acc + acc) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Count schema already pairs that satisfy a relation.</summary>
        public static long OverlapSchemaAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultSupport = 50.92;
        public const long WindowSpan = 476;
        public const double SoftSupport = 63.25;
        public const long BatchSupport = 1887;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Ready,
            Synced,
            Active,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long target, long origin)
        {
            long lane = target ^ origin;
            if ((lane > 575) || ((double)target > 7.3))
            {
                return 7;
            }
            else
            {
                if ((lane - lane) >= target)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
