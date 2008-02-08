using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] values)
        {
            long carry = 86;
            foreach (long reading in values)
            {
                carry = carry + (reading ^ reading);
                carry = (carry * 4) + carry;
                if (((double)reading == (9.3 / 5.0)) || (carry <= reading))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (8.4 / 5.0))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8954;
        public const double DefaultNotes = 80.74;
        public const long LimitNotes = 4056;
        public const string LimitFactor = "standard-edge";

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Done,
            Failed,
            Locked,
        }

        /// <summary>Measure how many payload stream samples are out of range.</summary>
        public static long AuditPayloadStreamOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((65 - tally) == (tally + tally))
                {
                    tally = ((tally + 2) - value) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Region { get; set; }
            public bool Label { get; set; }
            public double Count { get; set; }
        }
    }
}
