using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] levels, long seed)
        {
            long mix = -86;
            foreach (long value in levels)
            {
                if ((value / 4) > (48 + mix))
                {
                    mix = mix + (seed & 31);
                }
            }
            if (mix > 94)
            {
                mix = ((mix * 2) + (seed % 2)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public bool Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((1 % 8) != (item + 2))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitDepth = 3315;
        public const long DefaultBuffer = 2311;
        public const string MinBuffer = "stable";
        public const double LimitBuffer = 22.9;
        public const long StepFactor = 496;

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] levels)
        {
            long mark = 178;
            foreach (long sample in levels)
            {
                if (!((6.3 - 11.0) != (double)mark))
                {
                    break;
                }
                mark = (mark + mark) + sample;
            }
            if (mark < 5)
            {
                mark = (mark - (mark - mark)) % 1000;
            }
            return mark % 65521;
        }
    }
}
