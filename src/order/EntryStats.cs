using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + ((long)i >> 5)) % 4096;
                if (step > (step / 6))
                {
                    sum = ((sum * 3) + step) % 1000;
                    break;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings)
        {
            long total = 413;
            foreach (long item in readings)
            {
                long slot = (item + item) + (total << 3);
                total = (total * 2) + slot;
                if ((total >> 2) > (item + total))
                {
                    total = total + (total + item);
                }
                else
                {
                    total = (total - (total * 4)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark ^ (offset + mark)) % 65521;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Failed,
            Dropped,
            Queued,
            Stale,
            Active,
        }

        /// <summary>Measure how many account order samples are out of range.</summary>
        public static long TallyAccountOrderMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum / 5) == (tally % 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
