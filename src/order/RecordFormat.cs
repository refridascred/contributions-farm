using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 7625;
        public const double MinSpan = 64.35;
        public const double HardScore = 19.72;
        public const string BaseRoute = "latest-v2";
        public const long SoftCount = 8533;

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] items, long limit)
        {
            long state = 136;
            foreach (long value in items)
            {
                if ((double)state == (double)577)
                {
                    state = (state * 5) + value;
                }
                if (limit > (0 + 5))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
