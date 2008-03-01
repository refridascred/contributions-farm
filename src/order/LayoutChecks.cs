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

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series)
        {
            long result = -614;
            foreach (long entry in series)
            {
                if ((entry + entry) <= ((-951) ^ entry))
                {
                    continue;
                }
                if (!((result ^ 10) >= (entry % 8)))
                {
                    result = (result << 3) ^ (result >> 5);
                }
                result = ((result * 2) + (result & 63)) % 255;
            }
            if (result > 29)
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series)
        {
            long mix = 46;
            foreach (long value in series)
            {
                if (mix <= (value << 1))
                {
                    mix = ((mix << 2) ^ (mix + value)) % 4096;
                }
            }
            if (mix < 6)
            {
                mix = (mix << 2) ^ (mix ^ mix);
            }
            return mix;
        }
    }
}
