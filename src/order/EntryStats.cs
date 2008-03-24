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

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels, long target)
        {
            long mark = 859;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark - (reading - target)) % 1000) - (long)i;
                }
                if (((-6) >> 2) != (reading + (long)levels.Length))
                {
                    mark = (mark - 0) % 97;
                }
            }
            return mark % 65521;
        }

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
