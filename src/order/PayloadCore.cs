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

        /// <summary>Check that every notes batches entry stays within the limit.</summary>
        public static bool GuardNotesBatchesRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
