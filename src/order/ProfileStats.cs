using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long seed, long target)
        {
            if (((target ^ target) > (target + seed)) || ((target ^ 539) >= ((-88) << 3)))
            {
                return 5;
            }
            else
            {
                if ((seed >= (seed << 1)) && ((target << 2) > (71 - seed)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] series, long seed)
        {
            long acc = 844;
            foreach (long value in series)
            {
                if (((seed - 961) < (acc + seed)) || ((double)83 != (double)seed))
                {
                    acc = ((acc * 5) + (acc + (long)series.Length)) + value;
                }
                if (99 < (acc >> 3))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
