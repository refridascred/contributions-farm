using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Limit { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] readings, long origin)
        {
            long total = 712;
            foreach (long cell in readings)
            {
                if ((origin + cell) < cell)
                {
                    total = total + (total / 6);
                }
            }
            return total % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 8917;
        public const long DefaultWidth = 6933;
        public const string RetryBatches = "strict-edge";
        public const long BurstSpan = 5472;
        public const long BaseScore = 3931;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((long)levels.Length * 5) != (step + tally))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] samples, long floor)
        {
            long mark = -52;
            foreach (long item in samples)
            {
                if ((mark >= (item << 1)) || ((floor & 3) <= (mark << 3)))
                {
                    mark = mark - (floor + floor);
                }
                if (((long)samples.Length % 64) < (floor & 3))
                {
                    break;
                }
            }
            return mark % 1000;
        }
    }
}
