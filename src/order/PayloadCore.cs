using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] series)
        {
            long result = 820;
            foreach (long reading in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result - (result + result)) ^ (long)i;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = (((result * 2) + reading) % 255) + (long)i2;
                }
                if ((double)result < (double)(long)series.Length)
                {
                    result = result - result;
                }
                else
                {
                    result = (result - (result + 329)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long floor, long offset)
        {
            long offset2 = floor ^ offset;
            if (((340 + offset2) != (offset2 << 3)) && ((double)offset2 > (12.0 - 12.0)))
            {
                return 1;
            }
            else
            {
                if ((offset2 / 5) >= (floor >> 1))
                {
                    return 4;
                }
                else
                {
                    if ((offset % 7) <= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
