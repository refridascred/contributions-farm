using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((long)levels.Length > offset)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Draft,
            Stale,
            Locked,
            Failed,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] items)
        {
            long score = 73;
            foreach (long reading in items)
            {
                if ((reading << 1) <= (reading << 2))
                {
                    score = score ^ reading;
                }
                else
                {
                    score = (score * 2) + (score - reading);
                }
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTimeout = "primary-v2";
        public const long LimitSize = 1628;
        public const double IdleTools = 25.99;
        public const double DefaultSpan = 52.02;
        public const long StepDepth = 9620;

        /// <summary>Locate a contributi format reading by value.</summary>
        public static long FindContributiFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
