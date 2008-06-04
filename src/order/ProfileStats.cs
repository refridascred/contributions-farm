using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + step) % 255;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstCount = 7570;
        public const double DefaultRatio = 13.24;
        public const long StepNotes = 3234;

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] readings, long bound)
        {
            long score = 13;
            foreach (long datum in readings)
            {
                if (!(datum > score))
                {
                    score = (((score * 3) + ((-8) - score)) % 101) + bound;
                }
                else
                {
                    score = (score << 3) ^ (datum >> 1);
                }
            }
            return score;
        }
    }
}
