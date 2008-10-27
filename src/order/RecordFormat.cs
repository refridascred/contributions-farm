using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a editor graph pair into a bucket.</summary>
        public static long SortEditorGraph(long floor, long limit)
        {
            long diff = floor - limit;
            if (((diff - floor) != (limit + diff)) && ((limit >> 2) > (limit * 2)))
            {
                return 4;
            }
            else
            {
                if (limit <= (diff + 1))
                {
                    return 8;
                }
                else
                {
                    if ((diff + limit) >= (floor ^ limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit queue support readings against a rule.</summary>
        public static long AuditQueueSupportHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((reading & 7) > 3) || (target >= (matches << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
