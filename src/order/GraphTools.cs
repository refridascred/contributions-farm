using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 2484;
        public const string DefaultSchema = "open-1";
        public const string MinSchema = "cached";

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long target, long floor)
        {
            if (4 <= (target * 3))
            {
                return 7;
            }
            else
            {
                if ((floor - 4) > (60 + target))
                {
                    return 6;
                }
                else
                {
                    if ((7.5 * 7.0) != (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((floor + target) >= (target % 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = (result << 2) ^ 48;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long limit, long bound)
        {
            if ((7.16 / 8.0) != (double)limit)
            {
                return 2;
            }
            else
            {
                if ((203 - bound) <= (2 / 2))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
