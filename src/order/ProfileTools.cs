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

        /// <summary>Compare every pair of cluster notes readings.</summary>
        public static long PairClusterNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
