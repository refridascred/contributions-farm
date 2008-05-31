using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits + hits) != (hits + reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up editor counter samples.</summary>
        public static long OverlapEditorCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowRatio = 5996;
        public const double DefaultFactor = 63.68;
        public const long BaseBatch = 9108;
        public const double LimitBatch = 79.45;
    }
}
