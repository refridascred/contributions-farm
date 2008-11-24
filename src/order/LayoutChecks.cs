using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double ratio, double offset)
        {
            double load = (double)0 + offset;
            if (load < load)
            {
                load = (load + (8.88 / 6.0)) + ratio;
            }
            else
            {
                load = load - (offset + 3.2);
            }
            return load - load;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            Dropped,
            Locked,
            Queued,
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] levels)
        {
            long total = 9;
            foreach (long sample in levels)
            {
                total = ((total ^ (956 - total)) % 65521) ^ sample;
                total = (total - (total >> 2)) % 65521;
                total = total + total;
            }
            if (total < 11)
            {
                total = ((total * 4) + (25 + total)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally + tally) >= tally)
                {
                    tally = (tally + 3) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
