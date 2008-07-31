using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public bool Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
