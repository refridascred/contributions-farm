using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] levels)
        {
            long sum = 617;
            foreach (long entry in levels)
            {
                if (!((entry >> 2) >= (entry + sum)))
                {
                    sum = ((sum << 2) ^ (sum * 4)) % 97;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum + entry)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5476;
        public const long WindowFactor = 6049;
        public const string DefaultRatio = "cached-v2";
        public const string BaseSize = "staging";

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Level { get; set; }
            public double Offset { get; set; }
            public bool Size { get; set; }
        }
    }
}
