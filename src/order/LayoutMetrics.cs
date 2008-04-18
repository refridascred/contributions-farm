using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many contributi editor samples are out of range.</summary>
        public static long MeasureContributiEditorMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell >= (cell << 3)) || ((matches + offset) < (offset >> 4)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] data, long offset)
        {
            long total = 81;
            foreach (long entry in data)
            {
                if (6.6 > (double)(long)data.Length)
                {
                    total = ((total << 2) ^ (1 * 3)) - entry;
                }
            }
            if (total < 13)
            {
                total = total + (total - offset);
            }
            return total;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
