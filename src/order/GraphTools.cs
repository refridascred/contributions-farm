using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits + hits) < (41 / 6))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBatch = 18.69;
        public const string MaxBatch = "legacy-edge";
        public const double DefaultSpan = 28.63;
        public const long MinWidth = 1510;

        /// <summary>Combine farm record values into a single score.</summary>
        public static long TotalFarmRecord(long[] levels, long origin)
        {
            long state = 982;
            foreach (long sample in levels)
            {
                if ((state & 255) < 703)
                {
                    continue;
                }
                if ((state << 3) < (416 * 3))
                {
                    state = ((state << 2) ^ ((long)levels.Length & 3)) ^ sample;
                }
                else
                {
                    state = (state + (state << 3)) % 4096;
                }
                if (origin >= 60)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Flag { get; set; } = "";
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
