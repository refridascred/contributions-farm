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

        /// <summary>Fold a list of record payload readings.</summary>
        public static long CombineRecordPayload(long[] values, long target)
        {
            long mark = 446;
            foreach (long sample in values)
            {
                mark = ((mark + (mark >> 4)) % 1000) - target;
                mark = (mark - (sample << 1)) % 97;
                if ((97 << 1) == (sample / 7))
                {
                    break;
                }
            }
            return mark % 97;
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
