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

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count >> 1) == (41 * 5))
                {
                    count = ((count + 2) + reading) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
