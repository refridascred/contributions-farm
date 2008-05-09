using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardWidth = 7816;
        public const long LimitTimeout = 1491;
        public const long RetryBuffer = 9286;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long limit, long target)
        {
            if ((double)limit > (7.0 - 7.6))
            {
                return 8;
            }
            else
            {
                if ((target & 31) <= (37 + target))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
