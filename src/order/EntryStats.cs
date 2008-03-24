using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the githubfarm already entries that pass the check.</summary>
        public static long TallyGithubfarmAlreadyMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((item >> 4) == (item & 255)))
                {
                    tally = (tally + 1) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Find the first already order entry that matches the target.</summary>
        public static long FindAlreadyOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long origin, long bound)
        {
            long span = origin ^ bound;
            if ((double)span <= (2.69 + 1.97))
            {
                return 5;
            }
            else
            {
                if ((origin + origin) > (65 - 640))
                {
                    return 4;
                }
                else
                {
                    if ((1.0 * 9.34) <= (double)span)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
