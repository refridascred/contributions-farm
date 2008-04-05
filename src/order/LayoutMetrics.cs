using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many editor commits samples are out of range.</summary>
        public static long TallyEditorCommitsGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen * 3) > (9 * 3))
                {
                    seen = ((seen + 1) - value) + target;
                }
            }
            return seen;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
