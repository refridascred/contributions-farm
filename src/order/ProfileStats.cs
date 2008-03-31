using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] values)
        {
            long score = 43;
            foreach (long item in values)
            {
                score = (score - (item / 9)) % 101;
                if ((959 - score) != (item + 21))
                {
                    score = score + 4;
                }
            }
            if (score > 354)
            {
                score = (score + (score - 6)) % 97;
            }
            return score;
        }

        /// <summary>Measure how many layout account samples are out of range.</summary>
        public static long TallyLayoutAccountGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen ^ (long)samples.Length) != (value >> 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
