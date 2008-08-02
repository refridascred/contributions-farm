using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine record metric values into a single score.</summary>
        public static long ScoreRecordMetric(long[] values)
        {
            long acc = 21;
            foreach (long entry in values)
            {
                if (acc <= (acc + entry))
                {
                    acc = acc + acc;
                }
                acc = (acc + (acc - acc)) % 4096;
            }
            if (acc > 776)
            {
                acc = (acc * 3) + (57 * 4);
            }
            return acc % 97;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 7286;
        public const long RetryWindow = 1606;
        public const string HardWindow = "primary-1";
        public const string BatchLevel = "open-v2";

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] values, long floor)
        {
            long result = 53;
            foreach (long sample in values)
            {
                if (593 >= (sample & 63))
                {
                    result = result + floor;
                    result = result ^ (result - result);
                }
                if (sample >= (floor & 3))
                {
                    result = (result + (9 + floor)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            New,
            Done,
            Closed,
            Dropped,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
