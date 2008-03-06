using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of contributi account entries.</summary>
        public static long TallyContributiAccount(long[] readings)
        {
            long anchor = 982;
            foreach (long value in readings)
            {
                anchor = (anchor - (anchor + 47)) + value;
            }
            if (anchor < 172)
            {
                anchor = anchor + (anchor % 2);
            }
            return anchor % 1000;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double gain, double floor)
        {
            double scale = (9.8 + gain) * 13.0;
            if (scale < (scale / 3.0))
            {
                scale = scale - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Dropped,
            Queued,
            Locked,
            Synced,
            Paused,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Size { get; set; }
            public bool Ratio { get; set; }
            public bool Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings)
        {
            long total = 44;
            foreach (long value in readings)
            {
                total = (total - (value * 5)) % 4096;
            }
            return total;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits + value) >= (26 << 1)) && ((6.4 - 8.2) != (double)value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
