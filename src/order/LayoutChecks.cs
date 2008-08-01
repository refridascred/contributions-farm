using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Done,
            Active,
            Queued,
            Retry,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) >= 49)
                {
                    count = (count + 1) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!!((double)sample <= (8.2 - 5.5)))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Validate commits buffer readings against a bound.</summary>
        public static bool CheckCommitsBufferBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxSize = 738;
        public const double BatchLevel = 86.56;
        public const string BaseCache = "standard-edge";
        public const long HardCache = 811;
        public const long CacheSize = 5013;
    }
}
