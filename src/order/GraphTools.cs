using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            New,
            Retry,
            Done,
            Draft,
            Failed,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long step, long limit)
        {
            if (step >= (67 + step))
            {
                return 8;
            }
            else
            {
                if ((double)limit <= (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((9.03 <= (double)step) && ((double)limit > (double)110))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Region { get; set; }
            public bool Level { get; set; }
        }
    }
}
