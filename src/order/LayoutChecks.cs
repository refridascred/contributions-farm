using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((3 >> 3) >= (count << 2)) && !((double)reading != (14.0 / 4.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long origin, long offset)
        {
            long step = origin + offset;
            if (((double)origin > (16.0 * 12.0)) || ((double)step >= (double)4))
            {
                return 0;
            }
            else
            {
                if (offset >= (origin - step))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Failed,
            Paused,
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "alpha-v2";
        public const long BurstTimeout = 7145;
        public const long CacheWindow = 3010;
        public const string StepLevel = "local";
        public const long BurstWindow = 8609;

        /// <summary>Compare every pair of token buffer readings.</summary>
        public static long OverlapTokenBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
