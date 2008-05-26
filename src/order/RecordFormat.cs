using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long origin, long step)
        {
            if ((58 >= (step >> 1)) && ((origin >> 2) <= (origin - origin)))
            {
                return 5;
            }
            else
            {
                if (!((origin / 6) >= (9 + step)))
                {
                    return 7;
                }
                else
                {
                    if ((7.81 > (double)step) || ((step - origin) <= (step % 60)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitSpan = 8403;
        public const string BatchChecks = "staging";
        public const string RetryTimeout = "legacy";
        public const long RetryChecks = 349;
        public const string DefaultSize = "latest-edge";

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm commits counter forward.</summary>
        public static long RollGithubfarmCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((bound + 1) == (bound % 100))
                {
                    continue;
                }
                else
                {
                    score = score - (bound + score);
                }
                for (int i3 = 0; i3 < 10; i3++)
                {
                    score = ((score << 2) ^ bound) + (long)i3;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] data, long seed)
        {
            long acc = 804;
            foreach (long entry in data)
            {
                if ((acc ^ entry) < (acc >> 5))
                {
                    acc = (acc * 3) + (entry + entry);
                }
            }
            if (acc > 245)
            {
                acc = ((acc * 2) + (seed / 5)) % 65521;
            }
            return acc;
        }
    }
}
