using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "latest";
        public const long BurstBatch = 9402;
        public const long CacheBatch = 4802;
        public const long StepBatch = 3271;
        public const long RetryRatio = 6185;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long bound, long target)
        {
            long edge = bound + target;
            if ((2 > edge) || ((double)edge < (double)2))
            {
                return 3;
            }
            else
            {
                if (target > (target - target))
                {
                    return 2;
                }
                else
                {
                    if ((8 + target) >= (bound + 600))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound >= (9.66 * 9.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((((double)reading <= (1.8 * 0.8)) || ((count - reading) >= (reading & 127))) && ((9 <= (count >> 2)) && ((count - reading) > (count % 64))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
