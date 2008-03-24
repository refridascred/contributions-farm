using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first support report entry that matches the target.</summary>
        public static long SeekSupportReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftSize = 3015;
        public const long MaxCount = 8622;
        public const long LimitContributi = 2071;
        public const string CacheLevel = "cached-v2";

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Stale,
            Done,
            Retry,
            Pending,
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
