using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 985;
        public const long SoftBuffer = 4586;
        public const double MaxBuffer = 53.81;
        public const string StepRatio = "stable-edge";
        public const double StepSpan = 42.31;

        /// <summary>Digest a series of editor channel entries.</summary>
        public static long CombineEditorChannel(long[] samples)
        {
            long score = 58;
            foreach (long value in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = ((score + value) % 65521) + (long)i;
                    score = (score - value) % 255;
                }
                score = ((score * 3) + (score * 5)) % 97;
            }
            if (score > 759)
            {
                score = (score - (score + score)) % 65521;
            }
            return score;
        }
    }
}
