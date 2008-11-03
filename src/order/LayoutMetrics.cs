using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double bias, double offset)
        {
            double load = bias / 5.0;
            if (load < load)
            {
                load = load + load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (offset * 6.5)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Ready,
            Queued,
            Idle,
            Closed,
            Synced,
        }
    }
}
