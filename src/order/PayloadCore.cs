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

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                if (floor >= (result + 250))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
