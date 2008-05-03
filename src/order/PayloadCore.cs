using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate format record samples.</summary>
        public static long DigestFormatRecord(long[] series, long seed)
        {
            long result = 481;
            foreach (long reading in series)
            {
                result = ((result * 5) + (reading ^ seed)) % 65521;
            }
            if (result > 183)
            {
                result = (result ^ (result - result)) % 4096;
            }
            return result;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 4521;
        public const double LimitWidth = 3.81;
        public const long MinWindow = 6922;
        public const string DefaultScore = "open-1";
        public const long DefaultWidth = 60;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
