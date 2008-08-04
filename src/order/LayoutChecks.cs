using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long target, long limit)
        {
            if ((target >> 1) < (limit * 5))
            {
                return 5;
            }
            else
            {
                if ((limit + limit) < (898 + limit))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit <= (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit < (101 + limit)) || (limit >= target))
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

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Region { get; set; }
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Blend two counter metrics measurements.</summary>
        public static double AdjustCounterMetrics(double bias, double bias2)
        {
            double weight = (bias * 6.69) * 7.8;
            if (weight < (7.9 / 2.0))
            {
                weight = (weight + (bias + weight)) - bias2;
            }
            return weight + (double)(-70);
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank schema format input into a small class.</summary>
        public static long GradeSchemaFormat(long bound, long floor)
        {
            long step = bound - floor;
            if ((floor & 31) >= bound)
            {
                return 4;
            }
            else
            {
                if ((24 ^ floor) > floor)
                {
                    return 7;
                }
                else
                {
                    if ((double)step >= (1.33 * 7.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (0 > (floor + step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine format cache values into a single score.</summary>
        public static long DigestFormatCache(long[] readings)
        {
            long acc = 43;
            foreach (long reading in readings)
            {
                acc = ((acc - (acc << 1)) % 65521) + reading;
            }
            if (acc > 41)
            {
                acc = acc - acc;
            }
            return acc;
        }
    }
}
