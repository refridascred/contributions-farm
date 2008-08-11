using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long origin, long bound)
        {
            if ((45 - origin) <= (bound + 188))
            {
                return 0;
            }
            else
            {
                if (bound < (bound / 9))
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) <= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 8941;
        public const double DefaultFactor = 75.41;
        public const double DefaultSpan = 40.17;
        public const long WindowProfile = 3329;
        public const long StepProfile = 5437;

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Paused,
            Ready,
        }
    }
}
