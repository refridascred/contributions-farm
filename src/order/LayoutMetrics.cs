using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the buffer editor entries that pass the check.</summary>
        public static long TallyBufferEditorOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((-82) <= matches) || ((sample >> 3) == (matches + sample)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
