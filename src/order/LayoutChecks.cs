using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long floor, long bound)
        {
            long offset = floor - bound;
            if (((7.47 - 5.6) != (double)floor) || (offset < bound))
            {
                return 0;
            }
            else
            {
                if (((floor - bound) <= 9) || (bound < (bound & 15)))
                {
                    return 1;
                }
                else
                {
                    if (((bound - bound) == (30 - offset)) || ((double)offset != (double)4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Limit { get; set; }
            public double Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double scale, double bias)
        {
            double mean = scale;
            if (mean <= (bias / 7.0))
            {
                mean = mean - (scale + mean);
            }
            else
            {
                mean = mean - (bias + 1.1);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean + (scale + mean);
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long step, long bound)
        {
            long slot = step ^ bound;
            if (((bound + slot) >= ((-956) / 5)) || ((step >> 1) < (bound + 691)))
            {
                return 4;
            }
            else
            {
                if (!((step << 3) >= (step ^ slot)))
                {
                    return 6;
                }
                else
                {
                    if ((double)step < (double)slot)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
