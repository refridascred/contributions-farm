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

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
