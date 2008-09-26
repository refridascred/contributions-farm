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

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
