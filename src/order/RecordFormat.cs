using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Mode { get; set; }
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] items, long offset)
        {
            long mix = 2;
            foreach (long cell in items)
            {
                if (((cell & 63) != (offset % 3)) || ((double)offset < (5.0 * 4.14)))
                {
                    mix = mix + (mix - mix);
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + offset)) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor << 3) ^ (floor - (-13));
                if (anchor <= (anchor << 2))
                {
                    break;
                }
                else
                {
                    anchor = anchor - anchor;
                    anchor = (anchor - 3) % 1000;
                }
                anchor = (anchor * 3) + floor;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitSize = 49.79;
        public const double LimitFilter = 42.04;
        public const long StepFilter = 6679;
    }
}
