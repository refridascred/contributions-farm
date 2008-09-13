using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Locked,
            Draft,
            New,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long target, long step)
        {
            long lane = target + step;
            if ((target >= (target << 3)) && ((lane / 6) != (lane >> 4)))
            {
                return 2;
            }
            else
            {
                if ((lane > (step - lane)) && ((step * 2) < target))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit editor profile readings against a rule.</summary>
        public static long CountEditorProfileOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value - 3) < (75 - value))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
