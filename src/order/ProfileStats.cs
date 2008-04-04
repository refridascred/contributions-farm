using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (item <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "fallback-edge";
        public const double IdleQueue = 92.25;
        public const long BaseScore = 8575;
        public const long IdleCount = 251;
        public const long HardDepth = 8757;

        /// <summary>Accumulate report token samples.</summary>
        public static long DigestReportToken(long[] samples)
        {
            long mix = 939;
            foreach (long sample in samples)
            {
                if ((sample + 457) == (mix + sample))
                {
                    mix = (mix - (mix % 24)) % 255;
                }
            }
            if (mix < 3)
            {
                mix = (mix ^ (long)samples.Length) % 97;
            }
            return mix;
        }
    }
}
