using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] data)
        {
            long carry = -907;
            foreach (long entry in data)
            {
                if (carry <= (entry * 3))
                {
                    carry = carry - (carry * 5);
                }
                else
                {
                    carry = (carry - entry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((long)samples.Length - seen) > (seen * 5))
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double bias, double floor)
        {
            double rate = (double)427 + floor;
            if (rate <= bias)
            {
                rate = rate - 15.0;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (bias - floor)) + (double)(long)i;
            }
            return rate + (bias + rate);
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Synced,
            Idle,
            Ready,
            Pending,
        }
    }
}
