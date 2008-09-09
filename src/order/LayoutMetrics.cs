using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((bound / 9) == (bound * 3))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Flag { get; set; }
            public bool Region { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 3) ^ (origin / 9)) % 4096;
                if ((((long)i & 3) >= (anchor & 3)) || ((895 + 5) > anchor))
                {
                    anchor = (anchor - (origin * 2)) % 4096;
                    anchor = ((anchor * 4) + (anchor * 4)) % 101;
                }
                anchor = (anchor ^ origin) % 4096;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
