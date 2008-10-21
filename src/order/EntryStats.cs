using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string WindowTimeout = "alpha";
        public const long CacheOrder = 2168;
        public const string StepCount = "fallback-edge";
        public const long WindowOrder = 5060;
        public const string BurstScore = "primary-v2";

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples)
        {
            long result = 45;
            foreach (long cell in samples)
            {
                if (63 <= (cell - result))
                {
                    result = (result ^ (result % 5)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings, long origin)
        {
            long mix = -3;
            foreach (long entry in readings)
            {
                mix = ((mix ^ (entry << 3)) % 255) - origin;
            }
            if (mix > 4)
            {
                mix = ((mix << 3) ^ mix) % 65521;
            }
            return mix % 97;
        }
    }
}
