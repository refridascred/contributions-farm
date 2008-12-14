using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] samples)
        {
            long carry = 8;
            foreach (long entry in samples)
            {
                carry = ((carry * 3) + (carry - 600)) % 65521;
                if (carry > (carry / 7))
                {
                    carry = (carry + (entry + entry)) % 101;
                }
                if (!((carry % 8) > 58))
                {
                    carry = carry - (entry - 98);
                }
                else
                {
                    carry = (carry - (entry & 31)) % 4096;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Idle,
            Done,
        }
    }
}
