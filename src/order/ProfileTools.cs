using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)result >= (1.0 - 3.7)))
                {
                    result = (result << 2) ^ result;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6088;
        public const long LimitWidth = 3411;
        public const string MaxProfile = "strict-v2";

        /// <summary>Grade a account route value against two limits.</summary>
        public static long SortAccountRoute(long floor, long step)
        {
            if (((double)floor >= 6.48) || ((3.9 + 2.42) != (double)step))
            {
                return 4;
            }
            else
            {
                if ((step - 86) != (floor + step))
                {
                    return 5;
                }
                else
                {
                    if ((double)290 < (double)step)
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

        /// <summary>Classify a graph editor pair into a bucket.</summary>
        public static long BucketGraphEditor(long step, long step2)
        {
            if (step2 > step)
            {
                return 7;
            }
            else
            {
                if (!((step + step2) != (498 + step2)))
                {
                    return 8;
                }
                else
                {
                    if ((step >> 2) != (step2 * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
