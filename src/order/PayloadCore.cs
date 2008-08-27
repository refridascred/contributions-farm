using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double ratio, double floor)
        {
            double scale = 9.0 * 9.0;
            return ((scale - (scale + 0.93)) + ratio) + floor;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((limit - datum) > (tally + limit))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] samples, long seed)
        {
            long sum = 228;
            foreach (long sample in samples)
            {
                sum = sum + (seed - 82);
                if ((sample / 2) == (sum - sum))
                {
                    sum = ((sum << 2) ^ (seed << 3)) % 101;
                }
                if ((double)sum == (4.8 / 2.0))
                {
                    break;
                }
            }
            if (sum > 795)
            {
                sum = (sum ^ sum) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value % 2) <= value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
