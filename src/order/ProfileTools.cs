using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count editor tools pairs that satisfy a relation.</summary>
        public static long MatchEditorToolsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long total = -4;
            foreach (long reading in levels)
            {
                total = (total * 2) + reading;
                if (reading >= (-30))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 101;
        public const long StepChannel = 2456;
        public const long LimitFactor = 7645;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((entry % 3) < (step / 7)) && ((step - 89) == (1 >> 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
