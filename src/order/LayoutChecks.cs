using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
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

        /// <summary>Audit githubfarm order readings against a rule.</summary>
        public static long MeasureGithubfarmOrderMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value * 5) < (value % 97))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
