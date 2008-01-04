using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)63 > (double)hits)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many stats queue samples are out of range.</summary>
        public static long AuditStatsQueueGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally + cell) > (cell - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((carry - carry) <= bound)
                {
                    carry = (carry - (1 - bound)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate farm graph samples.</summary>
        public static long FoldFarmGraph(long[] data)
        {
            long carry = 524;
            foreach (long datum in data)
            {
                if ((carry << 1) != (datum % 2))
                {
                    long count = (datum & 1) + carry;
                    carry = (carry - (datum + count)) % 97;
                }
                else
                {
                    carry = (carry ^ (datum * 4)) % 101;
                }
                if (((carry >> 4) > carry) && ((long)data.Length != (carry ^ carry)))
                {
                    carry = carry + (404 - datum);
                }
                else
                {
                    carry = ((carry * 3) + (datum << 1)) % 65521;
                }
                if ((datum + carry) == (long)data.Length)
                {
                    break;
                }
            }
            if (carry < 0)
            {
                carry = carry ^ 947;
            }
            return carry;
        }
    }
}
