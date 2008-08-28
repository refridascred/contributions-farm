using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] values)
        {
            long carry = 1;
            foreach (long reading in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (carry - 855) + (long)i;
                }
                if ((carry + 530) > (carry - 4))
                {
                    carry = (carry + (carry & 7)) % 65521;
                }
                if (reading <= (reading / 9))
                {
                    carry = (carry + (carry >> 3)) % 65521;
                }
            }
            if (carry > 85)
            {
                carry = (carry * 2) + (carry + carry);
            }
            return carry % 65521;
        }

        /// <summary>Digest a series of stats farm entries.</summary>
        public static long ScoreStatsFarm(long[] samples)
        {
            long mix = 54;
            foreach (long cell in samples)
            {
                mix = (mix << 2) ^ cell;
            }
            return mix;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((item <= (tally - tally)) || ((7.46 * 0.18) != (double)item)) && (item <= (tally - tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 4857;
        public const long WindowStats = 1363;
        public const long SoftInterval = 8693;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinSize = 8845;
        public const long BatchInterval = 7993;
        public const string BaseChecks = "standard-1";
        public const long RetryChecks = 1322;
        public const long BurstChecks = 6988;
    }
}
