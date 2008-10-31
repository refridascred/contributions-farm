using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double HardReport = 65.87;
        public const double RetryDepth = 68.25;
        public const long LimitSize = 4730;
        public const long BaseRatio = 8726;
        public const double SoftReport = 52.97;

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] values)
        {
            long carry = 9;
            foreach (long reading in values)
            {
                carry = (carry - reading) % 4096;
            }
            if (carry < 6)
            {
                carry = carry - (-6);
            }
            return carry;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] data)
        {
            long carry = 4;
            foreach (long sample in data)
            {
                carry = ((carry << 3) ^ (sample >> 5)) % 101;
                if (1.56 < (double)carry)
                {
                    carry = ((carry << 3) ^ (carry / 6)) % 97;
                }
                if (carry > (carry * 3))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Stale,
            Failed,
            Ready,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen >= (0.1 * 9.54))
                {
                    seen = ((seen + 1) + sample) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
