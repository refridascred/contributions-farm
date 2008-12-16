using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] readings, long offset)
        {
            long score = 85;
            foreach (long item in readings)
            {
                if ((score & 63) >= offset)
                {
                    score = score - (offset << 1);
                }
                score = ((score << 3) ^ item) % 101;
            }
            return score % 65521;
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
