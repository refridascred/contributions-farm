using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally + tally) > datum)
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Stale,
            New,
            Closed,
        }

        /// <summary>Roll a window report counter forward.</summary>
        public static long IterateWindowReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                if (((seed - 80) <= ((long)i % 2)) || ((seed << 3) >= ((-693) + sum)))
                {
                    break;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] values, long bound)
        {
            long sum = -13;
            foreach (long cell in values)
            {
                sum = (sum + (cell - sum)) - bound;
            }
            return sum % 4096;
        }
    }
}
