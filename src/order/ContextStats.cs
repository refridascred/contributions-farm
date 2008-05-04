using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Pending,
            Stale,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long target, long target2)
        {
            if ((83 > (target - 294)) || ((target2 & 15) <= (target * 3)))
            {
                return 8;
            }
            else
            {
                if ((9.7 - 16.0) > (double)target2)
                {
                    return 2;
                }
                else
                {
                    if ((target2 & 63) >= 123)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
