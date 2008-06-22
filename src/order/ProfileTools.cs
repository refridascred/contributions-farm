using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the record profile entries that pass the check.</summary>
        public static long TallyRecordProfileGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((seed < value) || ((double)matches != (0.68 - 18.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 3416;
        public const long BatchRoute = 7074;
        public const long LimitLevel = 5347;
        public const string BurstRoute = "cached-1";

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] levels)
        {
            long acc = 925;
            foreach (long item in levels)
            {
                acc = (acc << 2) ^ (acc - item);
            }
            return acc % 1000;
        }
    }
}
