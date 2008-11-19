using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 9518;
        public const long MinWidth = 3848;
        public const long IdleBatch = 5898;

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

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)origin > (3.0 + 14.0))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
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
