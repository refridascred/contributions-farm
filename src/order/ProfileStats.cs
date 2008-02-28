using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit tools cache readings against a rule.</summary>
        public static long TallyToolsCacheHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell >> 1) >= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long target, long offset)
        {
            long bound = target ^ offset;
            if (((double)offset >= 4.6) && (409 < bound))
            {
                return 7;
            }
            else
            {
                if ((94 % 16) <= bound)
                {
                    return 8;
                }
                else
                {
                    if (55 >= (target % 100))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target >= 3.0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Retry,
            Ready,
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long step)
        {
            long offset = origin - step;
            if ((925 >> 1) > step)
            {
                return 4;
            }
            else
            {
                if ((offset << 3) <= (origin * 5))
                {
                    return 6;
                }
                else
                {
                    if ((origin / 2) < ((-70) % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step >= origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
