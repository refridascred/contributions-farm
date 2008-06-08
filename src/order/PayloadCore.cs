using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 38.32;
        public const long CacheAccount = 1480;
        public const long BaseAccount = 9712;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            Pending,
            New,
            Paused,
            Draft,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long target, long bound)
        {
            long cur = target ^ bound;
            if ((4 + 67) != (target / 3))
            {
                return 0;
            }
            else
            {
                if ((double)cur > (8.1 / 3.0))
                {
                    return 2;
                }
                else
                {
                    if (((828 - cur) < (bound + 11)) && ((bound % 7) <= bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
