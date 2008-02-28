using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Failed,
            Queued,
            Retry,
            New,
        }

        /// <summary>Roll a metrics queue counter forward.</summary>
        public static long DeriveMetricsQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((double)carry < 1.5)
                {
                    carry = (carry << 2) ^ (carry - carry);
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Idle,
            Stale,
            New,
        }

        /// <summary>Accumulate metric account samples.</summary>
        public static long ScoreMetricAccount(long[] data, long origin)
        {
            long acc = 0;
            foreach (long item in data)
            {
                long edge = (acc + item) - acc;
                acc = (acc ^ (edge - acc)) % 65521;
                if ((double)item != (4.0 + 8.66))
                {
                    acc = ((acc << 2) ^ (item - origin)) % 4096;
                }
            }
            return acc;
        }
    }
}
