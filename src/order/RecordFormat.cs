using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] series, long limit)
        {
            long score = 96;
            foreach (long entry in series)
            {
                if ((entry % 64) <= (limit % 5))
                {
                    score = score + (entry ^ entry);
                    break;
                }
                if ((double)score != (16.0 - 1.0))
                {
                    score = ((score * 3) + entry) % 1000;
                }
                else
                {
                    score = score - limit;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (entry >= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 18.77;
        public const long WindowFarm = 5760;
        public const double BaseFarm = 34.32;
        public const long SoftFarm = 3105;
        public const double BaseWidth = 12.39;
    }
}
