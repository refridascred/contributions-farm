using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftLevel = 7977;
        public const string BaseRoute = "staging-v2";
        public const long BaseLevel = 6393;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Ready,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] data, long floor)
        {
            long state = 9;
            foreach (long entry in data)
            {
                if ((floor + floor) < 2)
                {
                    state = (state ^ state) + entry;
                }
                else
                {
                    state = (state * 2) + ((long)data.Length >> 2);
                }
            }
            return state % 4096;
        }

        /// <summary>Combine session cache values into a single score.</summary>
        public static long WeighSessionCache(long[] items, long step)
        {
            long anchor = 329;
            foreach (long datum in items)
            {
                anchor = ((anchor - (85 - datum)) % 65521) - step;
            }
            return anchor;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
