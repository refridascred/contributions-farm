using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long step, long bound)
        {
            if (((bound >> 2) != (bound & 7)) || ((bound >> 1) < (step & 1)))
            {
                return 3;
            }
            else
            {
                if (!((step % 100) > bound))
                {
                    return 0;
                }
                else
                {
                    if ((2 - bound) >= (bound ^ bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step >= (755 >> 1)) || ((756 % 24) == (bound + bound)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next schema githubfarm value from a seed.</summary>
        public static long SeriesSchemaGithubfarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry * 5) + step) - (long)i2;
                }
                carry = ((carry * 2) + (step ^ 6)) % 255;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
