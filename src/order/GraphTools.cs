using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Failed,
            Synced,
        }

        /// <summary>Measure how many metric support samples are out of range.</summary>
        public static long MeasureMetricSupportGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((81 ^ (long)series.Length) > (entry >> 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
