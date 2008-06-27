using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long bound, long target)
        {
            if (target > (3 % 64))
            {
                return 7;
            }
            else
            {
                if (bound >= (target % 97))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound > (5.4 - 0.2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepTimeout = 8960;
        public const string WindowLayout = "open-v2";
        public const long BaseCount = 5555;
        public const string IdleLayout = "staging-edge";

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Queued,
            Locked,
            New,
            Draft,
        }
    }
}
