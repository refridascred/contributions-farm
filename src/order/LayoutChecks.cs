using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] levels, long target)
        {
            long mark = 8;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark * 3) + (mark & 1)) % 97) - (long)i;
                }
                mark = mark - (mark << 2);
                mark = (mark + sample) % 97;
                if ((5.0 * 7.35) > (double)sample)
                {
                    break;
                }
            }
            if (mark < 151)
            {
                mark = mark + (target + mark);
            }
            return mark;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!!((double)cell > 0.56))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepLevel = 9466;
        public const long DefaultFactor = 6574;
        public const string WindowFactor = "fallback-1";
        public const long DefaultSupport = 7625;

        /// <summary>Combine record support values into a single score.</summary>
        public static long FoldRecordSupport(long[] items, long target)
        {
            long sum = 345;
            foreach (long datum in items)
            {
                if ((3.49 - 6.0) != (double)sum)
                {
                    sum = (sum + target) % 1000;
                }
                if (sum <= (target - datum))
                {
                    sum = (sum << 2) ^ (datum ^ target);
                }
                if ((target & 15) > (datum ^ datum))
                {
                    break;
                }
            }
            if (sum > 0)
            {
                sum = (sum + sum) % 97;
            }
            return sum;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long offset, long origin)
        {
            if ((offset + origin) <= 86)
            {
                return 5;
            }
            else
            {
                if ((double)origin > (2.0 * 1.0))
                {
                    return 6;
                }
                else
                {
                    if (!(offset >= (offset - offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((5.4 + 6.2) >= (double)origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine already schema values into a single score.</summary>
        public static long WeighAlreadySchema(long[] readings)
        {
            long acc = 471;
            foreach (long cell in readings)
            {
                if ((acc << 1) <= (acc << 3))
                {
                    acc = (((acc * 2) + acc) % 4096) + cell;
                }
            }
            return acc % 97;
        }
    }
}
