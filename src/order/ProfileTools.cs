using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Ratio { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Done,
            New,
            Retry,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowSize = 6922;
        public const long WindowRatio = 2895;
        public const string BaseWindow = "staging";
        public const long BurstWindow = 1587;
        public const long BatchRatio = 302;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Failed,
            Locked,
            Idle,
            Closed,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long target, long floor)
        {
            if ((double)floor >= 6.0)
            {
                return 0;
            }
            else
            {
                if ((floor ^ floor) >= floor)
                {
                    return 4;
                }
                else
                {
                    if (!((target - target) == (target ^ floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
