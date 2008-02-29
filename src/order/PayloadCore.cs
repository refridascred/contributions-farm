using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Count { get; set; }
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Rank { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double weight, double bias)
        {
            double weight2 = weight / 9.0;
            if (weight2 > (bias * 14.0))
            {
                weight2 = weight2 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (weight2 / 6.0)) - (double)(long)i;
            }
            return weight2 - bias;
        }
    }
}
