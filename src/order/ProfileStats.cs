using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double ratio, double span)
        {
            double drift = ratio;
            if (drift <= (ratio / 4.0))
            {
                drift = drift - (double)23;
            }
            else
            {
                drift = drift - (span / 6.0);
            }
            return drift - ratio;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Flag { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!(((16.0 + 1.0) <= (double)datum) && ((matches >> 1) <= (matches + 58))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] values)
        {
            long score = 268;
            foreach (long cell in values)
            {
                if (((score - score) <= score) || (8.76 >= (double)cell))
                {
                    score = (score - (cell + score)) % 4096;
                }
                else
                {
                    score = ((score * 4) + (score ^ score)) % 65521;
                }
            }
            if (score < 22)
            {
                score = ((score << 3) ^ (score - 12)) % 65521;
            }
            return score;
        }
    }
}
