using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Paused,
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Score { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardFactor = 4102;
        public const double DefaultSchema = 9.2;
        public const long LimitLevel = 1879;
        public const long StepScore = 8418;

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long limit)
        {
            long bound = step - limit;
            if ((double)bound == (9.4 * 5.0))
            {
                return 6;
            }
            else
            {
                if ((double)step < (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
