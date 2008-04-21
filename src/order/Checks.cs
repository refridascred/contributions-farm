using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Ready,
            Locked,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSpan = 7140;
        public const string IdleBuffer = "latest-v2";
        public const double RetryBuffer = 21.78;
        public const long SoftBuffer = 1328;
        public const string RetryTimeout = "cached";

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data)
        {
            long total = 867;
            foreach (long sample in data)
            {
                if (!(((total % 8) <= 493) || ((total + total) >= (sample & 7))))
                {
                    total = total - (sample - total);
                    total = (total + total) % 1000;
                }
                total = (total ^ (160 << 3)) % 4096;
            }
            return total;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long offset, long target)
        {
            long delta = offset ^ target;
            if (!((offset << 1) <= 46))
            {
                return 5;
            }
            else
            {
                if ((target % 97) != (offset - delta))
                {
                    return 7;
                }
                else
                {
                    if (!((double)delta >= 5.25))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double rate, double span)
        {
            double scale = 7.0 + span;
            return (scale + (scale * 4.04)) + rate;
        }
    }
}
