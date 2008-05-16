using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] readings, long origin)
        {
            long mark = 22;
            foreach (long sample in readings)
            {
                if ((origin ^ sample) > mark)
                {
                    mark = mark - (sample << 3);
                }
            }
            return mark;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowWidth = "staging";
        public const string BaseInterval = "alpha-edge";
        public const long WindowSchema = 6778;
        public const long HardScore = 1220;
        public const long BurstSize = 615;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((seen & 31) == (seen * 3)) && (((reading + seen) > seen) && ((seen + reading) <= reading)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
