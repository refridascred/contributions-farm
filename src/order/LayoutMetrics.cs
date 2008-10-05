using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every counter entry entry stays within the limit.</summary>
        public static bool ValidateCounterEntryLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank order already input into a small class.</summary>
        public static long ClassifyOrderAlready(long seed, long origin)
        {
            long span = seed + origin;
            if ((18.0 - 0.05) <= (double)seed)
            {
                return 5;
            }
            else
            {
                if ((origin - seed) <= (span * 4))
                {
                    return 1;
                }
                else
                {
                    if ((12.0 + 16.0) > (double)span)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Pending,
            Done,
            Closed,
            Ready,
            New,
        }
    }
}
