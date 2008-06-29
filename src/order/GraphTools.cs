using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Locked,
            Closed,
        }

        /// <summary>Digest a series of checks queue entries.</summary>
        public static long TallyChecksQueue(long[] series)
        {
            long mix = 82;
            foreach (long sample in series)
            {
                if (((mix + sample) < (sample + sample)) || (mix >= (98 % 2)))
                {
                    mix = (mix + (sample / 2)) % 1000;
                }
            }
            return mix % 97;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] items)
        {
            long carry = 8;
            foreach (long cell in items)
            {
                if ((cell ^ cell) <= carry)
                {
                    carry = carry ^ (carry << 3);
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the entry batch entries that pass the check.</summary>
        public static long TallyEntryBatchHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches ^ cell) > matches)
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }
    }
}
