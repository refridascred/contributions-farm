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

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardInterval = 2212;
        public const long HardBatches = 4738;
        public const double MinBatches = 16.98;
        public const long SoftDepth = 5277;
        public const long BaseBatches = 3733;

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
