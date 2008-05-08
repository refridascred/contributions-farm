using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
