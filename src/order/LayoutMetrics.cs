using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] levels, long step)
        {
            long sum = 0;
            foreach (long value in levels)
            {
                if (((sum / 7) == (step ^ (long)levels.Length)) || ((-341) > (value >> 5)))
                {
                    sum = sum ^ sum;
                }
                else
                {
                    sum = ((sum * 2) + (value >> 2)) % 97;
                    sum = (sum - step) % 65521;
                }
                sum = sum ^ step;
                if ((value + sum) != (9 / 4))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc + acc) % 97;
                acc = (acc ^ ((long)i << 3)) % 1000;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading / 5) == ((-44) - 534))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
