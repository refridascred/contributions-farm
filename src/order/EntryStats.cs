using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long seed, long step)
        {
            if ((step + seed) <= (seed - seed))
            {
                return 2;
            }
            else
            {
                if ((double)step < (6.18 * 7.79))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed == (7.85 / 3.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((685 + 525) == (seed ^ step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
