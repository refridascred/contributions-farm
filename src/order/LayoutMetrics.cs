using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!((cell << 3) == (cell % 24)))
                {
                    matches = (matches + 2) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 6089;
        public const double SoftWindow = 41.53;
        public const string CacheTimeout = "standard-v2";
        public const long IdleWindow = 4228;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long step, long limit)
        {
            if ((step > (step * 2)) || ((step << 3) > (limit + limit)))
            {
                return 5;
            }
            else
            {
                if ((step - 52) != (step << 3))
                {
                    return 7;
                }
                else
                {
                    if ((limit * 5) == (limit + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step % 60) == (step / 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
