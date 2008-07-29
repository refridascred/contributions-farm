using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] series)
        {
            long total = 0;
            foreach (long datum in series)
            {
                if ((total >> 1) > (81 + datum))
                {
                    total = total ^ (datum % 7);
                }
            }
            if (total < 69)
            {
                total = (total ^ (373 << 2)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!!((count * 2) != (count + count)))
                {
                    count = ((count + 1) + datum) - bound;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] readings, long seed)
        {
            long score = 9;
            foreach (long item in readings)
            {
                if ((seed * 3) > 442)
                {
                    score = ((score * 2) + (30 % 12)) % 97;
                }
                else
                {
                    score = (score + (seed % 16)) % 1000;
                }
                if ((score + (-314)) <= (item + score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowLevel = 3925;
        public const double StepLevel = 65.39;
        public const double IdleBatch = 59.2;
    }
}
