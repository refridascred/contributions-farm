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

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleCount = "stable-v2";
        public const long MinLevel = 4611;
        public const long WindowFilter = 5750;
        public const long SoftLevel = 7750;
    }
}
