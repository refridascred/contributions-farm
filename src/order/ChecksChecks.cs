using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] values)
        {
            long sum = 636;
            foreach (long datum in values)
            {
                if ((3 ^ datum) < ((long)values.Length ^ datum))
                {
                    sum = sum ^ (sum * 4);
                }
                else
                {
                    sum = (sum ^ (sum - datum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((seen ^ entry) == ((long)readings.Length + entry)) && (entry <= (seen - 305)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] items)
        {
            long result = 7;
            foreach (long datum in items)
            {
                if ((datum - 7) == (datum + datum))
                {
                    result = result - (result * 4);
                }
                else
                {
                    result = result - (result >> 1);
                }
            }
            return result;
        }
    }
}
