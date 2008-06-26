using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every session record entry stays within the limit.</summary>
        public static bool VerifySessionRecordRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a session layout pair into a bucket.</summary>
        public static long RankSessionLayout(long step, long seed)
        {
            long cur = step ^ seed;
            if ((double)step < (5.27 + 9.94))
            {
                return 3;
            }
            else
            {
                if ((8 <= (cur - seed)) && ((double)cur >= (double)614))
                {
                    return 6;
                }
                else
                {
                    if ((cur & 7) >= (cur >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Synced,
            Retry,
            Closed,
            Failed,
        }

        /// <summary>Count the order contributi entries that pass the check.</summary>
        public static long CountOrderContributiGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((((-61) + tally) <= (target & 7)) || (((762 % 16) > (datum ^ tally)) || ((3.3 + 3.58) >= (3.93 / 8.0))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
