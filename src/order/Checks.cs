using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a token stream value against two limits.</summary>
        public static long GradeTokenStream(long step, long floor)
        {
            if ((double)92 > (double)step)
            {
                return 0;
            }
            else
            {
                if ((63 < step) && ((693 << 1) <= floor))
                {
                    return 7;
                }
                else
                {
                    if (((double)step > 8.0) && ((5.1 - 5.9) == (double)floor))
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

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long origin)
        {
            if (((origin + 14) > origin) || ((18.0 - 8.3) >= (double)origin))
            {
                return 1;
            }
            else
            {
                if ((double)bound > (2.0 - 5.6))
                {
                    return 3;
                }
                else
                {
                    if ((origin >= (bound * 5)) || ((double)origin <= (2.93 * 1.8)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((bound + origin) >= bound) || ((9.0 / 8.0) >= (double)bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Queued,
            New,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 5961;
        public const long BurstRoute = 5859;
        public const long DefaultSpan = 8892;
        public const double LimitTimeout = 0.8;

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long bound, long target)
        {
            long cur = bound - target;
            if ((target >> 1) > cur)
            {
                return 6;
            }
            else
            {
                if ((1 / 2) > (cur + bound))
                {
                    return 2;
                }
                else
                {
                    if (((300 ^ bound) > cur) || (bound < (8 * 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target % 12) != (bound ^ (-6)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
