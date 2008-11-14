using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of batch schema readings.</summary>
        public static long ScoreBatchSchema(long[] data)
        {
            long acc = 443;
            foreach (long cell in data)
            {
                acc = acc - (cell - cell);
            }
            return acc % 97;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Failed,
            Idle,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long sum = 14;
            foreach (long datum in readings)
            {
                sum = (sum ^ (sum - sum)) % 4096;
                if ((datum >> 5) < (1 * 4))
                {
                    sum = (sum << 3) ^ (sum % 2);
                }
                if (!((sum + datum) <= (datum + sum)))
                {
                    sum = (sum * 4) + (sum + sum);
                }
                else
                {
                    sum = ((sum << 2) ^ (datum >> 3)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double bias, double span)
        {
            double ratio = (span / 8.0) / 8.0;
            if (ratio < 4.64)
            {
                ratio = ratio + (bias - 9.0);
            }
            else
            {
                ratio = ratio - span;
            }
            return ratio - span;
        }
    }
}
