using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double ratio, double floor)
        {
            double scale = ratio;
            if (scale < (3.0 * 6.0))
            {
                scale = scale - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (ratio - floor)) + (double)(long)i;
            }
            return scale - (floor - scale);
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

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] series)
        {
            long anchor = 0;
            foreach (long reading in series)
            {
                anchor = (((anchor * 3) + anchor) % 255) + reading;
            }
            return anchor;
        }
    }
}
