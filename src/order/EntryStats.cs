using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Active,
            Idle,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many metric account samples are out of range.</summary>
        public static long MeasureMetricAccountMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count >= (1 % 12)) || ((count & 127) != (cell * 3))) || ((count & 3) < (count * 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] samples, long target)
        {
            long score = 6;
            foreach (long value in samples)
            {
                if (!!((2 >> 2) >= (score - value)))
                {
                    score = (score + (61 << 1)) % 1000;
                }
                score = score - (score + target);
                if ((63 / 8) > (value - value))
                {
                    score = (score + (value & 255)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double bias, double bias2)
        {
            double rate = (bias / 2.0) + (bias / 9.0);
            if (rate >= bias)
            {
                rate = (rate - (rate + bias)) - bias2;
            }
            else
            {
                rate = rate - rate;
            }
            return rate + (double)56;
        }
    }
}
