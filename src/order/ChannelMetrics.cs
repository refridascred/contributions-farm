using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Failed,
            Active,
            Closed,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] data, long limit)
        {
            long state = -59;
            foreach (long item in data)
            {
                state = ((state ^ (state % 8)) ^ item) + limit;
            }
            if (state > (-455))
            {
                state = ((state << 3) ^ (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Locked,
            Idle,
            Failed,
            Dropped,
        }
    }
}
