using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitSpan = "strict";
        public const string RetryBatch = "fallback";
        public const string RetryTimeout = "cached";
        public const long StepSpan = 1447;
        public const string MinTimeout = "local-edge";

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long limit, long offset)
        {
            if ((limit + (-67)) == (limit % 16))
            {
                return 1;
            }
            else
            {
                if ((offset > (5 + limit)) || ((44 ^ limit) > (offset + limit)))
                {
                    return 2;
                }
                else
                {
                    if ((4 >> 1) >= (offset + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
