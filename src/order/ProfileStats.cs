using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryInterval = 6105;
        public const string MaxCount = "latest-edge";
        public const string MaxBatches = "legacy-v2";
        public const double RetryBatches = 16.77;
        public const long BurstLevel = 7392;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long target, long target2)
        {
            long span = target ^ target2;
            if (!(5.0 < (double)span))
            {
                return 3;
            }
            else
            {
                if ((double)target2 < (4.1 * 17.0))
                {
                    return 7;
                }
                else
                {
                    if ((81 + span) != (target & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
