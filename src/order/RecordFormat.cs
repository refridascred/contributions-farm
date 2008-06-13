using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if (((step - step) < (step ^ step)) || ((step - total) == (66 + 9)))
                {
                    total = (total - total) % 97;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((872 + limit) <= (tally << 3)))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
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

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
