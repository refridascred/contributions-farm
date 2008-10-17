using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit schema queue readings against a rule.</summary>
        public static long TallySchemaQueueHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((380 / 9) >= item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double drift = bias;
            if (drift >= bias)
            {
                drift = (drift - 5.2) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 9.0) - (double)(long)i;
            }
            return drift - (double)(-3);
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Idle,
            Done,
            Draft,
            Stale,
            New,
        }
    }
}
