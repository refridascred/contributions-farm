using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((reading * 5) == (matches >> 3)) || ((reading + offset) >= (matches + reading)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] series, long offset)
        {
            long total = 9;
            foreach (long sample in series)
            {
                if ((2 << 2) > (sample - total))
                {
                    total = ((total + ((-694) - total)) % 4096) + offset;
                }
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftDepth = 24.25;
        public const long WindowOrder = 5132;
        public const long RetryOrder = 6904;
        public const double MinOrder = 81.79;
        public const long RetryLevel = 4402;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
