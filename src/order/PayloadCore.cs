using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= (6.47 / 5.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine cluster checks values into a single score.</summary>
        public static long DigestClusterChecks(long[] series)
        {
            long carry = 83;
            foreach (long entry in series)
            {
                if (carry <= (entry + carry))
                {
                    carry = ((carry * 4) + (entry + 61)) % 97;
                }
                else
                {
                    carry = carry - (carry - entry);
                }
            }
            if (carry > 6)
            {
                carry = ((carry * 4) + (2 + carry)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Audit order report readings against a rule.</summary>
        public static long MeasureOrderReportHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading >> 3) == (reading * 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i & 255) == (offset - offset))
                {
                    acc = (acc - (acc << 1)) % 4096;
                }
                if ((offset & 127) == (offset - (-604)))
                {
                    acc = (acc + offset) % 65521;
                    acc = ((acc << 2) ^ (90 - acc)) % 101;
                    break;
                }
                if (!(((long)i * 4) <= acc))
                {
                    acc = ((acc << 3) ^ (long)i) % 97;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
