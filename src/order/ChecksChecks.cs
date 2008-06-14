using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a channel metrics pair into a bucket.</summary>
        public static long GradeChannelMetrics(long step, long bound)
        {
            if ((step / 9) >= step)
            {
                return 1;
            }
            else
            {
                if ((step + step) >= ((-829) * 5))
                {
                    return 3;
                }
                else
                {
                    if (step >= (step + step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Done,
            Paused,
            Retry,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 9786;
        public const long IdleRatio = 2226;
        public const string StepContributi = "legacy-1";
        public const string LimitContributi = "fallback-edge";
        public const long MinContributi = 4066;
    }
}
