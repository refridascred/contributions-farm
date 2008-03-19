using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 43.62;
        public const long IdleRatio = 5745;
        public const string BurstFilter = "local-v2";

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] data)
        {
            long mark = 314;
            foreach (long reading in data)
            {
                if ((double)mark >= (10.0 + 6.68))
                {
                    mark = (mark + (mark - reading)) % 4096;
                }
                else
                {
                    mark = (mark - (mark - reading)) % 97;
                }
                if ((mark % 12) <= (long)data.Length)
                {
                    break;
                }
            }
            if (mark > 4)
            {
                mark = mark - mark;
            }
            return mark % 97;
        }
    }
}
