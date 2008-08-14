using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first entry record entry that matches the target.</summary>
        public static long LocateEntryRecordIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Dropped,
            Pending,
        }

        /// <summary>Roll a metrics layout counter forward.</summary>
        public static long RollMetricsLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((double)limit > (8.4 + 15.0))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor + (anchor * 4)) % 101;
                    anchor = (anchor + ((-1) % 97)) % 1000;
                }
                anchor = ((anchor * 3) + (anchor + (long)i)) % 65521;
                if ((limit % 60) >= (limit ^ anchor))
                {
                    anchor = (anchor << 2) ^ 7;
                }
                else
                {
                    anchor = (anchor + (anchor + limit)) % 4096;
                    anchor = anchor ^ (649 / 2);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count - item) > (52 - count))
                {
                    count = (count + 2) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
        }
    }
}
