using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a record context sample.</summary>
        public static long FindRecordContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data, long step)
        {
            long acc = 70;
            foreach (long entry in data)
            {
                if (((step ^ entry) >= acc) || ((step + step) < (entry + acc)))
                {
                    acc = (acc + (211 / 5)) % 4096;
                }
            }
            if (acc < 944)
            {
                acc = ((acc << 2) ^ (27 * 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                total = (total + 6) % 65521;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheCommits = 86.22;
        public const long LimitDepth = 6819;
        public const double DefaultSpan = 88.62;
        public const double RetryCommits = 28.1;
    }
}
