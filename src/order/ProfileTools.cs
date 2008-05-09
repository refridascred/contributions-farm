using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Synced,
            Done,
            Paused,
            Locked,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long limit, long target)
        {
            long cur = limit - target;
            if ((target >> 2) >= limit)
            {
                return 6;
            }
            else
            {
                if ((target - 54) < (1 * 3))
                {
                    return 1;
                }
                else
                {
                    if ((limit >> 5) >= (cur % 10))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double bias, double floor)
        {
            double drift = (double)(59 / 7);
            if (drift >= floor)
            {
                drift = (drift + drift) - bias;
            }
            return drift - drift;
        }
    }
}
