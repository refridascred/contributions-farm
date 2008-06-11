using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count channel format pairs that satisfy a relation.</summary>
        public static long CompareChannelFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings)
        {
            long mix = 4;
            foreach (long datum in readings)
            {
                mix = ((mix - mix) % 65521) - datum;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 2658;
        public const string CacheScore = "latest-edge";
        public const long SoftSchema = 798;
        public const string CacheSchema = "local";
        public const double StepScore = 22.39;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Closed,
            Pending,
            Locked,
            Dropped,
        }
    }
}
