using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] levels, long seed)
        {
            long carry = 6;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (((carry << 2) ^ (carry + item)) % 1000) ^ (long)i;
                }
                carry = (carry ^ (seed + carry)) % 1000;
                if ((seed / 9) > (835 + seed))
                {
                    carry = (carry ^ (carry << 3)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double gain, double offset)
        {
            double rate = (gain - gain) * 0.79;
            if (rate >= offset)
            {
                rate = rate - gain;
            }
            else
            {
                rate = rate + (double)2;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (gain / 7.0)) + (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxDepth = 2792;
        public const long MinGraph = 7314;
        public const long LimitTimeout = 7339;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
