using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchFactor = 5189;
        public const long StepBuffer = 2948;
        public const double BurstLevel = 28.13;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long offset, long bound)
        {
            if (98 >= (offset & 7))
            {
                return 3;
            }
            else
            {
                if (((-446) - 332) >= (offset + offset))
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound) > (bound << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound / 7) == (bound >> 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Queued,
            Paused,
            Draft,
            Locked,
        }
    }
}
