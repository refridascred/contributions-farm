using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] samples)
        {
            long sum = 545;
            foreach (long cell in samples)
            {
                sum = sum + sum;
                sum = sum - (cell - sum);
                if (cell <= sum)
                {
                    sum = sum + ((-21) / 4);
                }
                if (((sum << 1) < sum) || ((double)cell > 20.0))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((step & 127) < (item & 1))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches != (double)value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
