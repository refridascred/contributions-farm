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

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Retry,
            Locked,
        }

        /// <summary>Iterate the context checks series from a seed.</summary>
        public static long StepContextChecks(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
