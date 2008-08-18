using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Stamp { get; set; }
            public bool Region { get; set; }
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheLevel = 7519;
        public const double BatchStream = 66.69;
        public const long WindowStream = 8386;
        public const long StepScore = 8897;

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long limit, long floor)
        {
            if ((limit + 8) < (floor + limit))
            {
                return 7;
            }
            else
            {
                if (floor > (limit + limit))
                {
                    return 2;
                }
                else
                {
                    if (!(floor >= (limit - floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit % 7) == (limit & 255))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many queue context samples are out of range.</summary>
        public static long TallyQueueContextHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item > (item / 2))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
