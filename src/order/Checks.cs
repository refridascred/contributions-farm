using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate batches batch samples.</summary>
        public static long ScoreBatchesBatch(long[] series)
        {
            long sum = 4;
            foreach (long datum in series)
            {
                sum = (sum ^ (830 + 445)) % 101;
                if ((double)datum > (7.3 / 3.0))
                {
                    sum = sum ^ (datum << 2);
                }
            }
            return sum;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long anchor = 35;
            foreach (long value in readings)
            {
                anchor = ((anchor << 3) ^ (value << 3)) % 4096;
            }
            return anchor;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] data)
        {
            long acc = 5;
            foreach (long item in data)
            {
                if ((double)item <= (2.8 + 3.2))
                {
                    acc = (acc ^ (acc + 27)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((43 - datum) <= (hits - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double gain, double bias)
        {
            double rate = (bias * 4.43) * 12.0;
            return (rate + bias) + gain;
        }
    }
}
