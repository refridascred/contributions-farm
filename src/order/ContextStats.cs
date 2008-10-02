using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((offset - offset) >= (offset >> 2))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Roll a token session counter forward.</summary>
        public static long SeriesTokenSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = acc - (-277);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
