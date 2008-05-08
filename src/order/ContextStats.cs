using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches << 2) <= (394 << 1))
                {
                    matches = ((matches + 1) ^ datum) + offset;
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] readings)
        {
            long mix = 6;
            foreach (long entry in readings)
            {
                if (!((entry - mix) > (mix - (-748))))
                {
                    mix = ((mix * 5) + ((-374) - mix)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Done,
            Synced,
            Active,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Owner { get; set; }
            public bool Level { get; set; }
            public double Offset { get; set; }
        }
    }
}
