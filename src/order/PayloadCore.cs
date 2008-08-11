using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long limit, long target)
        {
            if ((8.0 + 6.67) < (15.0 + 3.54))
            {
                return 8;
            }
            else
            {
                if ((9 >> 2) < limit)
                {
                    return 6;
                }
                else
                {
                    if (!(((-684) << 2) == (limit + 70)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.01 / 6.0) < (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 4337;
        public const double MaxWidth = 34.96;
        public const long StepLevel = 9448;
        public const long IdleSpan = 7074;
    }
}
