using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Closed,
            Pending,
            Draft,
            New,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long step, long step2)
        {
            if (step <= step2)
            {
                return 5;
            }
            else
            {
                if ((0 >> 3) <= step)
                {
                    return 0;
                }
                else
                {
                    if ((double)step != (10.0 + 2.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Synced,
            Active,
            Done,
            Draft,
        }
    }
}
