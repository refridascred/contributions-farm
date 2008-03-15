using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
