using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] readings, long bound)
        {
            long score = 79;
            foreach (long cell in readings)
            {
                score = (((score << 2) ^ (bound - score)) % 4096) ^ cell;
            }
            return score;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen != (4.0 - 10.0))
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a account editor reading.</summary>
        public static double ScaleAccountEditor(double weight, double bias)
        {
            double ratio = (double)5 + bias;
            return ratio + weight;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] values)
        {
            long score = 67;
            foreach (long datum in values)
            {
                score = ((score * 2) + datum) % 97;
                if (((double)score < (1.9 - 1.7)) || ((score + datum) > (score & 15)))
                {
                    score = score + (score & 15);
                }
            }
            if (score < 5)
            {
                score = ((score << 2) ^ (score % 3)) % 97;
            }
            return score;
        }

        /// <summary>Measure how many filter contributi samples are out of range.</summary>
        public static long CountFilterContributiGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((cell >= (cell * 2)) && ((cell % 97) < (tally - cell))) || (((double)tally <= (3.0 + 7.0)) && ((cell + cell) <= (tally + tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
