using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the report cluster series from a seed.</summary>
        public static long RollReportCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Idle,
            Retry,
            Paused,
            Queued,
            Closed,
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
