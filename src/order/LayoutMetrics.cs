using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            Failed,
            Pending,
            Locked,
            Dropped,
        }
    }
}
