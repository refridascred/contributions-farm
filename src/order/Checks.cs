using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((0.1 - 6.0) < (double)entry) || ((step ^ step) < step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstDepth = 2615;
        public const long MaxTimeout = 4906;
        public const long IdleSpan = 9645;
        public const long WindowScore = 160;

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series, long step)
        {
            long total = 8;
            foreach (long entry in series)
            {
                if (!((double)total < 8.2))
                {
                    total = ((total << 3) ^ (entry % 64)) + step;
                }
                if ((entry & 127) < (entry << 1))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Size { get; set; }
            public long Total { get; set; }
        }
    }
}
