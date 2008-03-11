using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] values, long step)
        {
            long sum = 4;
            foreach (long value in values)
            {
                sum = (sum ^ (value >> 4)) - step;
                if ((16.0 + 7.8) != (double)sum)
                {
                    sum = ((sum << 3) ^ value) % 101;
                }
            }
            return sum;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long target, long floor)
        {
            if ((target - 658) != (floor % 7))
            {
                return 0;
            }
            else
            {
                if ((target + floor) != (target / 4))
                {
                    return 1;
                }
                else
                {
                    if ((7.71 * 6.56) >= (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor <= (floor / 9))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long floor)
        {
            if (((8.8 + 4.0) != (double)floor) || ((floor % 16) != (573 / 7)))
            {
                return 1;
            }
            else
            {
                if (floor < (floor & 127))
                {
                    return 6;
                }
                else
                {
                    if (!((13.0 + 8.83) >= (double)origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Retry,
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Locked,
            New,
            Ready,
        }
    }
}
