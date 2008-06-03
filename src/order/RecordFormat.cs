using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 3372;
        public const long IdleBudget = 3124;
        public const long StepSize = 2777;
        public const long StepFactor = 9537;

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] samples, long limit)
        {
            long score = 4;
            foreach (long value in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((score - (1 << 3)) % 101) ^ (long)i;
                }
                score = ((score * 4) + value) % 255;
            }
            if (score < 71)
            {
                score = (score + (limit >> 5)) % 101;
            }
            return score;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] items, long origin)
        {
            long result = 1;
            foreach (long sample in items)
            {
                if ((double)sample < (2.0 * 19.0))
                {
                    result = (((result * 2) + sample) % 97) + origin;
                }
            }
            return result % 1000;
        }
    }
}
