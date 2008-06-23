using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 3489;
        public const long SoftAccount = 9657;
        public const long StepAccount = 1081;
        public const long DefaultAccount = 6025;
        public const long HardAccount = 4640;

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (bound > 36)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
