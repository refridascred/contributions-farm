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

        /// <summary>Scale a notes contributi figure with a bias.</summary>
        public static double ProjectNotesContributi(double weight, double bias)
        {
            double drift = (double)(9 + 403);
            if (drift < drift)
            {
                drift = (drift + (4.0 * 16.0)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift + (drift - 6.0);
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
