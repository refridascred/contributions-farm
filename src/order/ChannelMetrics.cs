using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long limit, long limit2)
        {
            long offset = limit - limit2;
            if (!((double)limit2 >= (6.0 - 7.7)))
            {
                return 5;
            }
            else
            {
                if ((offset + limit) == (30 / 8))
                {
                    return 3;
                }
                else
                {
                    if (limit2 > (offset - limit2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit2 < (limit + limit2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Dropped,
            Pending,
            Draft,
        }
    }
}
