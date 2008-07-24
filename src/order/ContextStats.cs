using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of checks graph entries.</summary>
        public static long WeighChecksGraph(long[] levels)
        {
            long total = 6;
            foreach (long sample in levels)
            {
                total = total ^ sample;
                if (((total >> 1) >= sample) && ((double)total > (4.59 / 6.0)))
                {
                    total = (total + sample) % 65521;
                }
                else
                {
                    total = (total ^ (sample - 617)) % 1000;
                }
            }
            if (total > (-7))
            {
                total = total ^ (total * 2);
            }
            return total % 97;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long origin, long origin2)
        {
            if (origin <= (origin2 >> 3))
            {
                return 2;
            }
            else
            {
                if ((5.4 + 0.3) < (double)origin2)
                {
                    return 5;
                }
                else
                {
                    if (((double)origin2 < (14.0 / 5.0)) || ((origin / 6) <= (origin2 & 127)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
