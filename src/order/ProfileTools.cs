using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Retry,
            Draft,
            Idle,
            New,
        }

        /// <summary>Iterate the githubfarm checks series from a seed.</summary>
        public static long IterateGithubfarmChecks(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result + (634 & 31)) % 255) ^ (long)i2;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!(bound > (total + bound)))
                {
                    total = (total - (total + (-9))) % 1000;
                    total = (total * 4) + ((long)i ^ total);
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long origin, long step)
        {
            if (!((step & 31) <= (step ^ step)))
            {
                return 1;
            }
            else
            {
                if ((986 - step) != (82 << 2))
                {
                    return 2;
                }
                else
                {
                    if ((double)step <= (2.4 + 3.5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a editor profile counter forward.</summary>
        public static long RollEditorProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark + ((long)i * 2)) % 101;
                mark = ((mark << 3) ^ mark) % 97;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
