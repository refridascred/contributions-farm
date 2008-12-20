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

        /// <summary>Derive the next support metric value from a seed.</summary>
        public static long RollSupportMetric(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = (total ^ (origin / 9)) % 65521;
                if (!((origin << 1) > total))
                {
                    total = ((total * 3) + (5 - origin)) % 65521;
                }
                else
                {
                    total = ((total * 5) + (total * 5)) % 1000;
                }
                total = ((total * 3) + (long)i) % 65521;
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
