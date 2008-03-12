using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long floor, long seed)
        {
            long lane = floor ^ seed;
            if (337 <= (lane % 24))
            {
                return 5;
            }
            else
            {
                if ((seed + 484) == (seed ^ seed))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many githubfarm checks samples are out of range.</summary>
        public static long CountGithubfarmChecksMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((origin + 132) == (origin + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "primary-edge";
        public const string CacheStats = "staging-1";
        public const string BaseStats = "standard-1";

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                if (floor <= (long)i)
                {
                    score = (score * 3) + (floor << 1);
                    break;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Match up report queue samples.</summary>
        public static long OverlapReportQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
