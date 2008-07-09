using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of command batch readings.</summary>
        public static long TotalCommandBatch(long[] items, long origin)
        {
            long mix = 274;
            foreach (long cell in items)
            {
                mix = (mix ^ (origin + origin)) % 1000;
                if (1.8 <= (double)cell)
                {
                    mix = mix - (cell + cell);
                }
            }
            return mix;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long offset, long offset2)
        {
            if ((offset + offset2) < (822 + offset))
            {
                return 0;
            }
            else
            {
                if (((4 % 16) <= offset) && ((offset2 + 1) <= (535 << 1)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a command commits sample.</summary>
        public static long FindCommandCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a session token sample.</summary>
        public static long SeekSessionTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up editor cluster samples.</summary>
        public static long OverlapEditorClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
