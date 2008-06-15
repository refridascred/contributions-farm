using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] series)
        {
            long sum = 2;
            foreach (long cell in series)
            {
                if ((112 + cell) >= sum)
                {
                    sum = ((sum << 3) ^ (cell + cell)) % 97;
                }
            }
            if (sum > 2)
            {
                sum = (sum - (sum >> 2)) % 101;
            }
            return sum;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count session support pairs that satisfy a relation.</summary>
        public static long OverlapSessionSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseMetrics = "open-v2";
        public const double BatchMetrics = 18.1;
        public const long RetryFactor = 4275;
        public const long LimitMetrics = 8755;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum / 5) >= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
