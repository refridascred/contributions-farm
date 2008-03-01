using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "local-edge";
        public const string BatchSize = "alpha";
        public const double MaxEditor = 68.86;
        public const double LimitTimeout = 62.42;

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long seed, long bound)
        {
            long prev = seed + bound;
            if (((-5) + prev) >= seed)
            {
                return 7;
            }
            else
            {
                if (((bound << 2) >= (prev / 5)) && ((4 + 73) >= (bound - prev)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long floor, long step)
        {
            if ((floor * 3) >= (floor % 8))
            {
                return 1;
            }
            else
            {
                if (((step + floor) <= (floor - 3)) && ((floor & 63) >= (2 / 8)))
                {
                    return 4;
                }
                else
                {
                    if (!((13.0 + 10.0) < (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((9.57 + 9.0) == (double)floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] levels, long offset)
        {
            long score = 808;
            foreach (long cell in levels)
            {
                if ((score ^ cell) < 8)
                {
                    score = ((score * 3) + (score - cell)) % 255;
                }
                score = ((score * 4) + (offset + score)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Total { get; set; }
            public bool Region { get; set; }
            public double Mode { get; set; }
        }
    }
}
