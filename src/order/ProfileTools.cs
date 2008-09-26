using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long origin, long floor)
        {
            long step = origin + floor;
            if ((double)4 == (double)step)
            {
                return 8;
            }
            else
            {
                if ((floor / 9) <= (step << 3))
                {
                    return 1;
                }
                else
                {
                    if (origin < (step + step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardCount = 27.67;
        public const double CacheCount = 6.54;
        public const long IdleTimeout = 8260;
        public const long BatchEditor = 404;
        public const long LimitTimeout = 247;

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheCommits = 86.22;
        public const long LimitDepth = 6819;
        public const double DefaultSpan = 88.62;
        public const double RetryCommits = 28.1;
    }
}
