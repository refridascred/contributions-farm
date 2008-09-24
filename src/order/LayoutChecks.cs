using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] readings, long step)
        {
            long score = -216;
            foreach (long sample in readings)
            {
                if ((0 % 5) <= score)
                {
                    score = (((score ^ score) % 101) ^ sample) - step;
                }
                else
                {
                    score = ((score << 3) ^ 6) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Iterate the entry githubfarm series from a seed.</summary>
        public static long StepEntryGithubfarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 3) + origin) % 65521;
                if (!((double)sum < (9.48 - 3.87)))
                {
                    sum = sum ^ (34 >> 5);
                    sum = (sum * 5) + (origin - origin);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long seed, long step)
        {
            long bound = seed + step;
            if (step < seed)
            {
                return 2;
            }
            else
            {
                if ((bound + bound) != (bound & 127))
                {
                    return 4;
                }
                else
                {
                    if (!((double)seed <= (16.0 / 6.0)))
                    {
                        return 5;
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
