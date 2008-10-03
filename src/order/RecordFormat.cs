using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 20.6;
        public const double BatchInterval = 59.48;
        public const long SoftToken = 5159;
        public const string WindowToken = "cached-v2";
        public const double MinInterval = 27.47;

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 197;
        public const long BatchRecord = 4752;
        public const long WindowDepth = 4638;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((2 < (reading - (-323))) && ((6.9 * 1.0) != (double)reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
        }
    }
}
