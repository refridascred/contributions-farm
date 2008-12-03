using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 72.16;
        public const long CacheBudget = 6748;
        public const long StepSupport = 8266;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long origin, long bound)
        {
            if ((bound << 1) >= 384)
            {
                return 5;
            }
            else
            {
                if (((625 & 127) != (origin + bound)) || ((-28) <= (bound >> 1)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Dropped,
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 8953;
        public const string MinBatches = "alpha-edge";
        public const long MaxBatches = 6389;
        public const long IdleDepth = 2031;
        public const string IdleBatches = "latest-v2";

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
