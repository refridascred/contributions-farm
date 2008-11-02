using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((86 + datum) >= datum) && ((2.5 / 2.0) == (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
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
