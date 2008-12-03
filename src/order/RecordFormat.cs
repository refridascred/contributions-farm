using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 4571;
        public const long BatchCount = 4151;
        public const string BatchContributi = "stable-v2";

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Queued,
            Done,
            Closed,
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] items)
        {
            long acc = 7;
            foreach (long entry in items)
            {
                if ((16.0 - 3.0) >= (double)acc)
                {
                    acc = acc - entry;
                }
                if (acc >= (3 & 31))
                {
                    acc = (acc + (54 - 9)) % 65521;
                }
                if (((entry - 71) != (73 ^ 888)) && (((-39) + entry) >= (entry + 600)))
                {
                    break;
                }
            }
            if (acc < 0)
            {
                acc = (acc ^ (acc << 2)) % 97;
            }
            return acc % 97;
        }
    }
}
