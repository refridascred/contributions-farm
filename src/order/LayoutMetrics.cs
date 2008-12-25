using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            Queued,
            Retry,
        }

        /// <summary>Count the cluster token entries that pass the check.</summary>
        public static long AuditClusterTokenHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((sample + 80) > (sample + sample)) && !(hits <= (sample / 6)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
