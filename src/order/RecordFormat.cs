using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Done,
            Idle,
            Paused,
            New,
        }

        /// <summary>Look up the position of a checks contributi sample.</summary>
        public static long LocateChecksContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (21 < (cell & 7))
                {
                    seen = (seen + 1) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
