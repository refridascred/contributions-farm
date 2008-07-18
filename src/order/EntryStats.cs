using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen * 4) != (sample % 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count != (6.7 / 5.0))
                {
                    count = ((count + 2) ^ reading) + seed;
                }
            }
            return count;
        }
    }
}
