using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((datum + datum) < (datum * 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cluster format entries that pass the check.</summary>
        public static long MeasureClusterFormatGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)hits <= 5.0)
                {
                    hits = ((hits + 3) - entry) + origin;
                }
            }
            return hits;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (70 > (hits % 16))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
