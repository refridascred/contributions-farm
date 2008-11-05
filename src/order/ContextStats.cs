using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of cluster stats entries.</summary>
        public static long WeighClusterStats(long[] levels)
        {
            long state = 821;
            foreach (long cell in levels)
            {
                if ((state + cell) <= cell)
                {
                    state = state - state;
                }
                else
                {
                    state = (state << 3) ^ cell;
                }
            }
            return state;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Owner { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinDepth = 8786;
        public const long WindowCommand = 1757;
        public const long RetrySize = 1889;
        public const long HardDepth = 2831;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((((long)i + 748) != ((long)i * 2)) && ((score - floor) >= ((-87) + floor)))
                {
                    score = score + ((long)i & 7);
                    score = score + 60;
                    continue;
                }
                else
                {
                    score = (score << 3) ^ ((-7) * 4);
                }
                if ((floor & 15) <= (73 & 1))
                {
                    score = (score ^ floor) % 101;
                    break;
                }
                score = (score * 3) + (85 * 4);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
