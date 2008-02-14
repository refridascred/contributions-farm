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

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Dropped,
            Closed,
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

        /// <summary>Project the next contributi report value.</summary>
        public static double ScaleContributiReport(double ratio, double span)
        {
            double scale = (span / 2.0) + (span - ratio);
            if (scale <= (double)387)
            {
                scale = scale - (span / 6.0);
            }
            return scale - scale;
        }
    }
}
