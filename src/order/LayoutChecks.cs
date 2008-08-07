using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long bound, long offset)
        {
            if ((offset - bound) < (64 ^ bound))
            {
                return 1;
            }
            else
            {
                if (offset <= (8 >> 2))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double ratio, double offset)
        {
            double drift = ratio - offset;
            if (drift < (drift * 8.9))
            {
                drift = drift + (double)545;
            }
            else
            {
                drift = drift - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (double)3;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Owner { get; set; }
            public double Mode { get; set; }
            public double Region { get; set; }
        }
    }
}
