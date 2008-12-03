using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
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

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
