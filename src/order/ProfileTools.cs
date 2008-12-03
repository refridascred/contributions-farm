using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((double)(long)i != (double)28)
                {
                    result = (result * 2) + (floor >> 4);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long target, long bound)
        {
            long lane = target - bound;
            if (((-9) + target) > (bound >> 3))
            {
                return 5;
            }
            else
            {
                if (((double)bound > (18.0 / 5.0)) && ((lane + target) < lane))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Compare every pair of filter cache readings.</summary>
        public static long CompareFilterCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
