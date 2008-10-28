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

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
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

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values)
        {
            long acc = 83;
            foreach (long reading in values)
            {
                acc = ((acc + (acc * 3)) % 1000) ^ reading;
            }
            if (acc > (-69))
            {
                acc = acc + (72 & 31);
            }
            return acc;
        }
    }
}
