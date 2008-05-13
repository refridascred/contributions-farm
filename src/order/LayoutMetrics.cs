using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank entry payload input into a small class.</summary>
        public static long ClassifyEntryPayload(long step, long step2)
        {
            if ((double)step2 < (double)step)
            {
                return 6;
            }
            else
            {
                if ((980 & 3) < (step2 / 5))
                {
                    return 1;
                }
                else
                {
                    if (((step2 - step2) <= (step + step2)) || ((double)step >= (2.0 * 1.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step2 > step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Retry,
            Ready,
            Failed,
            Paused,
            New,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
