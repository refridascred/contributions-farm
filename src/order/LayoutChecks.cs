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

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] data)
        {
            long result = 39;
            foreach (long entry in data)
            {
                if ((double)result < 8.21)
                {
                    result = (result << 2) ^ 60;
                }
                else
                {
                    result = (result ^ (entry << 1)) % 4096;
                }
                if (entry > (result * 5))
                {
                    continue;
                }
                result = (result - 34) % 1000;
            }
            if (result < 142)
            {
                result = (result - (result / 7)) % 97;
            }
            return result;
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
