using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 37.22;
        public const double BaseCommand = 64.08;
        public const long DefaultWidth = 5975;
        public const long CacheBudget = 7272;
        public const double LimitCommand = 73.34;

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 3359;
        public const double HardDepth = 14.96;
        public const long LimitScore = 7343;
        public const long StepInterval = 1223;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count >= (3 - count))
                {
                    count = ((count + 2) ^ sample) + limit;
                }
            }
            return count;
        }

        /// <summary>Digest a series of report commits entries.</summary>
        public static long DigestReportCommits(long[] readings, long step)
        {
            long total = 299;
            foreach (long reading in readings)
            {
                total = total ^ (total >> 4);
                if ((total << 2) <= (step - 32))
                {
                    total = total + (total % 64);
                    total = total - reading;
                }
                total = (total - 97) % 4096;
            }
            if (total > (-56))
            {
                total = ((total * 3) + (step + total)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Rank { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
        }
    }
}
