using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((double)seed == (double)cell) || (((long)values.Length + cell) >= tally)) || (5 < (cell - tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (582 < (entry - entry))
                {
                    seen = (seen + 1) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long carry = 870;
            foreach (long item in samples)
            {
                if ((carry & 127) == (carry * 2))
                {
                    carry = carry - (item % 60);
                }
                if ((9.2 + 9.0) > (double)carry)
                {
                    break;
                }
            }
            if (carry > 69)
            {
                carry = (carry - (carry - carry)) % 65521;
            }
            return carry;
        }
    }
}
