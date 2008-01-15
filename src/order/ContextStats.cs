using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] values, long limit)
        {
            long anchor = 0;
            foreach (long cell in values)
            {
                if (17.0 <= (double)limit)
                {
                    anchor = (((anchor * 3) + (90 + anchor)) % 1000) - cell;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitInterval = 2850;
        public const string StepNotes = "staging-1";
        public const double DefaultNotes = 35.68;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
