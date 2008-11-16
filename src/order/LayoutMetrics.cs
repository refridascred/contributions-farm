using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long step, long step2)
        {
            long span = step ^ step2;
            if ((double)step2 <= (7.61 - 6.8))
            {
                return 4;
            }
            else
            {
                if ((7.0 / 7.0) != (double)span)
                {
                    return 0;
                }
                else
                {
                    if ((step2 / 5) > (span + span))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Closed,
            Idle,
            Failed,
            Dropped,
        }
    }
}
