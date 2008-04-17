using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account tools samples are out of range.</summary>
        public static long CountAccountToolsGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)item < (0.6 - 5.5))
                {
                    matches = (matches + 3) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate tools queue samples.</summary>
        public static long CombineToolsQueue(long[] levels)
        {
            long acc = 345;
            foreach (long cell in levels)
            {
                acc = (acc + (cell % 8)) % 4096;
            }
            if (acc > 396)
            {
                acc = (acc + (acc << 3)) % 255;
            }
            return acc;
        }
    }
}
