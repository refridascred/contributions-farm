using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long offset, long target)
        {
            if ((target % 12) == (435 / 2))
            {
                return 7;
            }
            else
            {
                if ((double)target <= 8.9)
                {
                    return 2;
                }
                else
                {
                    if ((target + offset) >= target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
