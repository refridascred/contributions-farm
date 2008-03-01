using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long step, long floor)
        {
            if ((floor & 7) >= (332 & 1))
            {
                return 0;
            }
            else
            {
                if ((8.41 + 3.2) <= (double)step)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long step, long step2)
        {
            long bound = step + step2;
            if ((step % 60) >= 878)
            {
                return 0;
            }
            else
            {
                if ((step - step2) < bound)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            Closed,
            Pending,
            Active,
        }
    }
}
