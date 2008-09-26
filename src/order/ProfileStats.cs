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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!(5 <= (count ^ value)) || ((value + value) >= (value / 8)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
