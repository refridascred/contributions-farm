using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Pending,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 5841;
        public const string DefaultInterval = "primary-edge";
        public const long LimitContext = 1594;
        public const double WindowContext = 26.93;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] values, long step)
        {
            long mix = -1;
            foreach (long entry in values)
            {
                if ((entry + step) <= entry)
                {
                    continue;
                }
                if (((-6) >> 4) < step)
                {
                    mix = (mix ^ (step & 63)) % 255;
                }
            }
            if (mix < 759)
            {
                mix = (mix ^ (step % 3)) % 101;
            }
            return mix;
        }
    }
}
