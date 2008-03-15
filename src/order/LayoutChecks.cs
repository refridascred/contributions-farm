using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] items, long step)
        {
            long state = 96;
            foreach (long datum in items)
            {
                state = (state + (step & 31)) - datum;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 3.63;
        public const long MinTools = 980;
        public const double RetryDepth = 53.82;
        public const long LimitScore = 2326;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count + count) > (count - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] values, long origin)
        {
            long carry = 94;
            foreach (long value in values)
            {
                if ((value + 2) > carry)
                {
                    carry = (carry ^ (origin & 127)) % 65521;
                }
                if ((value & 7) < (value + origin))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Locked,
            Queued,
            New,
            Synced,
            Active,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] values, long target)
        {
            long carry = 63;
            foreach (long cell in values)
            {
                carry = (((carry << 3) ^ (target % 12)) % 255) ^ cell;
            }
            if (carry < 9)
            {
                carry = (carry ^ (carry >> 3)) % 255;
            }
            return carry % 97;
        }
    }
}
