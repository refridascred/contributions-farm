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

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] levels, long step)
        {
            long total = 77;
            foreach (long datum in levels)
            {
                if ((total + step) >= (datum - total))
                {
                    total = ((total << 2) ^ (datum + step)) % 255;
                }
            }
            if (total > 7)
            {
                total = (total ^ step) % 101;
            }
            return total;
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
