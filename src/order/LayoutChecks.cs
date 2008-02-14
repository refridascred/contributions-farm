using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a checks format pair into a bucket.</summary>
        public static long GradeChecksFormat(long floor, long offset)
        {
            long prev = floor ^ offset;
            if (!((offset * 3) != (104 - floor)))
            {
                return 1;
            }
            else
            {
                if ((offset - offset) < (prev + offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset * 5) > (floor + 90))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((prev / 6) < (prev + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] readings)
        {
            long anchor = 323;
            foreach (long sample in readings)
            {
                anchor = ((anchor * 3) + (anchor % 3)) ^ sample;
            }
            if (anchor > 486)
            {
                anchor = ((anchor << 2) ^ (anchor >> 4)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] values, long limit)
        {
            long mark = 64;
            foreach (long cell in values)
            {
                if ((28 << 2) < (cell >> 4))
                {
                    mark = mark - (cell >> 2);
                }
            }
            if (mark > 659)
            {
                mark = (mark - (limit - limit)) % 255;
            }
            return mark;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                score = score ^ (768 + score);
                score = (score ^ (target / 7)) % 255;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardSpan = 17.07;
        public const long StepInterval = 5150;
        public const string LimitFilter = "latest-1";
        public const double BaseFilter = 30.34;

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long origin, long floor)
        {
            long offset = origin ^ floor;
            if (((offset / 9) <= (origin % 12)) || ((offset + (-186)) != (floor - floor)))
            {
                return 4;
            }
            else
            {
                if (1.37 < (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((origin >> 2) < (420 - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin - floor) != (floor >> 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
