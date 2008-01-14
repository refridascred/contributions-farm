using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the tools token entries that pass the check.</summary>
        public static long AuditToolsTokenGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry + 459) <= (hits - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine contributi token values into a single score.</summary>
        public static long WeighContributiToken(long[] series)
        {
            long anchor = -5;
            foreach (long cell in series)
            {
                anchor = anchor - (4 >> 1);
                if (!((double)cell < (9.27 + 8.87)))
                {
                    break;
                }
            }
            if (anchor < 60)
            {
                anchor = (anchor - (anchor % 64)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((sum + (-605)) == (bound >> 2))
                {
                    sum = ((sum * 2) + (sum & 15)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Dropped,
            Idle,
            Retry,
        }
    }
}
