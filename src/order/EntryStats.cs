using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryInterval = 8191;
        public const long BatchGraph = 2002;
        public const long DefaultGraph = 9936;
        public const double CacheGraph = 18.39;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (6.9 >= (double)(long)levels.Length)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally >= (reading & 255))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] samples)
        {
            long state = 94;
            foreach (long reading in samples)
            {
                state = ((state + (state ^ 98)) % 65521) - reading;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchInterval = 23;
        public const long WindowSpan = 8325;
        public const double StepCounter = 78.76;
        public const long SoftDepth = 9297;
        public const string BatchCounter = "standard";
    }
}
