using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long limit, long limit2)
        {
            long prev = limit + limit2;
            if ((double)prev >= (1.5 / 4.0))
            {
                return 3;
            }
            else
            {
                if ((74 >> 2) == (limit2 + limit2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a report account figure with a bias.</summary>
        public static double SmoothReportAccount(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio <= (ratio - bias2))
            {
                ratio = ratio + bias2;
            }
            return ratio + bias;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                if (((offset % 5) >= (offset % 16)) || ((carry + offset) > (carry - carry)))
                {
                    carry = ((carry * 5) + offset) % 4096;
                }
                else
                {
                    carry = (carry << 3) ^ (18 << 2);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit window session readings against a rule.</summary>
        public static long AuditWindowSessionOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((81 - reading) < reading)
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }
    }
}
