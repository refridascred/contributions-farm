using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command format readings.</summary>
        public static long TotalCommandFormat(long[] levels)
        {
            long score = 8;
            foreach (long datum in levels)
            {
                if ((10 << 2) >= (datum >> 3))
                {
                    score = (score ^ (score % 3)) % 65521;
                }
            }
            if (score < 7)
            {
                score = (score - (score % 3)) % 4096;
            }
            return score;
        }
    }
}
