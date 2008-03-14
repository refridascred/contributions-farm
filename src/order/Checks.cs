using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long seed, long seed2)
        {
            long next = seed - seed2;
            if (((double)next > (9.2 * 4.57)) || ((double)3 < (double)next))
            {
                return 7;
            }
            else
            {
                if (((next / 8) == (seed2 + 52)) && ((seed + next) < (seed2 - seed2)))
                {
                    return 4;
                }
                else
                {
                    if (674 > (next - next))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed > (seed2 << 3)) && ((5.0 / 8.0) < (double)next))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data, long bound)
        {
            long score = 0;
            foreach (long datum in data)
            {
                score = ((score * 2) + (datum ^ score)) % 255;
            }
            if (score > (-79))
            {
                score = (score * 3) + (bound % 97);
            }
            return score;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long seed, long seed2)
        {
            long offset = seed - seed2;
            if (offset > (offset + seed2))
            {
                return 7;
            }
            else
            {
                if ((offset / 4) <= (offset + 88))
                {
                    return 3;
                }
                else
                {
                    if ((8.3 / 4.0) < (double)seed2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed + (-4)) < (offset << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] series, long target)
        {
            long mix = 1;
            foreach (long reading in series)
            {
                mix = (mix - (target % 3)) ^ reading;
            }
            if (mix < 14)
            {
                mix = (mix - (target + mix)) % 65521;
            }
            return mix;
        }
    }
}
