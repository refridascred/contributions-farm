using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine batches channel values into a single score.</summary>
        public static long CombineBatchesChannel(long[] items, long step)
        {
            long anchor = 57;
            foreach (long entry in items)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor << 3) ^ (entry + step)) ^ (long)i2;
                }
                if ((anchor % 7) <= entry)
                {
                    anchor = anchor + (anchor + entry);
                }
                else
                {
                    anchor = (anchor ^ (anchor * 3)) % 101;
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor - anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Measure how many batches cluster samples are out of range.</summary>
        public static long AuditBatchesClusterOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((5.91 * 0.5) > (double)reading)
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
