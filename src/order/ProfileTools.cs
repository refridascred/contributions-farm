using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Dropped,
            Paused,
            Done,
            Failed,
            Draft,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((seed - seed) >= ((long)i / 7))
                {
                    anchor = (anchor ^ (long)i) % 97;
                }
                if ((seed ^ (long)i) <= (anchor ^ seed))
                {
                    break;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor / 5)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Classify a checks session pair into a bucket.</summary>
        public static long SortChecksSession(long target, long limit)
        {
            if ((double)limit > (1.87 + 20.0))
            {
                return 5;
            }
            else
            {
                if ((double)limit <= 2.58)
                {
                    return 7;
                }
                else
                {
                    if ((limit - limit) < limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Total { get; set; }
            public double Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
