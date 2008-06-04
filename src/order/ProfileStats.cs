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

        /// <summary>Fold a list of context schema readings.</summary>
        public static long FoldContextSchema(long[] series, long origin)
        {
            long acc = 959;
            foreach (long entry in series)
            {
                if ((origin ^ acc) == (8 >> 1))
                {
                    acc = (acc + (acc + (long)series.Length)) - entry;
                }
                else
                {
                    acc = ((acc * 3) + origin) % 101;
                }
            }
            if (acc < 7)
            {
                acc = (acc - 538) % 255;
            }
            return acc;
        }
    }
}
