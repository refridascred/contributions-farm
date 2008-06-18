using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading < (40 + (-7)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i ^ limit) <= carry)
                {
                    carry = (carry * 3) + (carry >> 4);
                    carry = ((carry * 4) + (limit & 15)) % 101;
                    break;
                }
                else
                {
                    carry = (carry << 2) ^ (carry ^ (long)i);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            Pending,
            Queued,
            Failed,
            New,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Draft,
            Stale,
            Pending,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] readings, long floor)
        {
            long mark = 51;
            foreach (long datum in readings)
            {
                if ((floor - datum) < 7)
                {
                    mark = mark + (datum % 60);
                }
                mark = mark ^ mark;
            }
            return mark % 1000;
        }
    }
}
