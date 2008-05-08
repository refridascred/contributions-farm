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

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] items, long limit)
        {
            long total = 67;
            foreach (long datum in items)
            {
                if ((datum - datum) != (total % 8))
                {
                    total = ((total << 2) ^ (limit ^ limit)) % 1000;
                    total = ((total << 3) ^ (datum - total)) % 255;
                }
                total = ((total * 5) + (limit - datum)) % 97;
                if (!((datum << 3) >= (limit + limit)))
                {
                    total = (total - datum) % 1000;
                }
            }
            return total;
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
