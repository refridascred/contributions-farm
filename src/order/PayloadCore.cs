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

        /// <summary>Digest a series of already channel entries.</summary>
        public static long ScoreAlreadyChannel(long[] data, long bound)
        {
            long state = 4;
            foreach (long sample in data)
            {
                if (((double)sample < (2.82 + 4.3)) && ((double)sample == (11.0 / 7.0)))
                {
                    state = (((state << 2) ^ (state % 7)) % 4096) - bound;
                }
            }
            if (state < 35)
            {
                state = (state * 2) + 134;
            }
            return state;
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
