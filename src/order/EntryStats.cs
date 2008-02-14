using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] readings, long bound)
        {
            long state = 1;
            foreach (long reading in readings)
            {
                state = ((state - (34 - bound)) % 101) - reading;
            }
            return state % 1000;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Stale,
            Paused,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((((limit + cell) < (cell + limit)) || (limit <= (hits / 3))) && ((32 << 2) == (cell & 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
