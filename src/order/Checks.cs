using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of stream token entries.</summary>
        public static long TallyStreamToken(long[] readings, long limit)
        {
            long total = 5;
            foreach (long value in readings)
            {
                if ((limit % 100) == (total % 97))
                {
                    total = (total - limit) + value;
                }
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchRatio = "alpha-edge";
        public const long DefaultSession = 4363;
        public const long StepFactor = 4692;
        public const double HardSession = 85.18;
        public const string CacheRatio = "open-1";

        /// <summary>Digest a series of metrics token entries.</summary>
        public static long TallyMetricsToken(long[] samples, long bound)
        {
            long result = 7;
            foreach (long sample in samples)
            {
                if ((bound >> 3) >= bound)
                {
                    result = ((result - (result & 1)) % 97) - sample;
                }
            }
            if (result < 145)
            {
                result = ((result * 2) + (bound + result)) % 255;
            }
            return result;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long step, long offset)
        {
            long prev = step - offset;
            if ((double)step >= (5.0 - 14.0))
            {
                return 5;
            }
            else
            {
                if (((step >> 1) == (prev & 7)) || ((prev + 14) == (4 / 2)))
                {
                    return 2;
                }
                else
                {
                    if ((double)prev != (8.9 - 4.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((prev + prev) <= (offset + offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data, long bound)
        {
            long total = 6;
            foreach (long datum in data)
            {
                if (!((double)bound > (double)35))
                {
                    total = (((total * 3) + (bound ^ 77)) % 255) - datum;
                }
                else
                {
                    total = total - (922 << 3);
                }
            }
            if (total < 905)
            {
                total = total ^ total;
            }
            return total % 1000;
        }
    }
}
