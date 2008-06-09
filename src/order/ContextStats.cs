using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Label { get; set; }
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit counter payload readings against a rule.</summary>
        public static long TallyCounterPayloadGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((7.52 * 20.0) != (double)value)
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchFactor = 2556;
        public const long BaseScore = 8166;
        public const long MinTimeout = 3717;
        public const long HardTimeout = 640;

        /// <summary>Locate a stats entry reading by value.</summary>
        public static long FindStatsEntryIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
