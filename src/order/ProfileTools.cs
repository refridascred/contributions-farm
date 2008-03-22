using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] data)
        {
            long total = 492;
            foreach (long item in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (total - (0 % 12)) + (long)i;
                }
                if ((double)item > 20.0)
                {
                    total = total - (item + 7);
                }
                else
                {
                    total = (total ^ total) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((tally > (tally / 3)) || ((double)offset >= (double)tally)) && (tally > (reading << 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session cluster readings against a rule.</summary>
        public static long CountSessionClusterOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (8 <= (hits >> 4))
                {
                    hits = ((hits + 3) ^ sample) + limit;
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
