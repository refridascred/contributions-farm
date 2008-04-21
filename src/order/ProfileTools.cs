using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally % 12) < (item * 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] items)
        {
            long score = -20;
            foreach (long item in items)
            {
                if (!((item + item) <= (score << 3)))
                {
                    score = score ^ (4 >> 1);
                }
            }
            if (score > 46)
            {
                score = (score - score) % 101;
            }
            return score % 1000;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] levels)
        {
            long total = 7;
            foreach (long cell in levels)
            {
                if ((53 & 1) <= (cell + total))
                {
                    total = (total * 3) + (307 >> 3);
                }
            }
            return total;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public bool Total { get; set; }
        }
    }
}
