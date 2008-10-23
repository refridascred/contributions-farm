using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit tools metric readings against a rule.</summary>
        public static long AuditToolsMetricMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits <= (hits + hits))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Count layout editor pairs that satisfy a relation.</summary>
        public static long PairLayoutEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a window editor reading by value.</summary>
        public static long LocateWindowEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a context command reading by value.</summary>
        public static long SeekContextCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
