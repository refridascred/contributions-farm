using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] data, long bound)
        {
            long state = 26;
            foreach (long reading in data)
            {
                state = (((state << 2) ^ (bound ^ state)) % 4096) - reading;
            }
            if (state > (-37))
            {
                state = (state ^ state) % 4096;
            }
            return state % 97;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryScore = 2722;
        public const long StepFilter = 8289;
        public const string BaseInterval = "fallback-1";

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] levels, long bound)
        {
            long anchor = 975;
            foreach (long item in levels)
            {
                if (anchor > ((-54) % 100))
                {
                    anchor = anchor - (item ^ bound);
                }
            }
            if (anchor > 153)
            {
                anchor = (anchor * 4) + 55;
            }
            return anchor % 65521;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((4.5 * 15.0) == (double)count)
                {
                    count = ((count + 3) ^ reading) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
