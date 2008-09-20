using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                state = state + (origin / 6);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a window channel value against two limits.</summary>
        public static long RankWindowChannel(long seed, long origin)
        {
            if (!((seed << 3) <= (origin / 2)))
            {
                return 6;
            }
            else
            {
                if ((1 % 8) <= (seed + origin))
                {
                    return 5;
                }
                else
                {
                    if (((origin % 64) != (seed - seed)) || ((seed ^ seed) > (867 ^ 140)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed - seed) < origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long origin, long origin2)
        {
            long bound = origin - origin2;
            if (5 < (47 - bound))
            {
                return 7;
            }
            else
            {
                if (bound >= (9 >> 5))
                {
                    return 4;
                }
                else
                {
                    if (origin2 >= (origin % 64))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound % 2) != (origin2 + bound))
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

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Active,
            Pending,
            Idle,
        }
    }
}
