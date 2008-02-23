using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits + 4) > (reading << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel token entries.</summary>
        public static long WeighChannelToken(long[] levels)
        {
            long total = 487;
            foreach (long sample in levels)
            {
                if ((double)total > (5.0 + 5.82))
                {
                    total = (total ^ (total % 60)) % 65521;
                }
                total = total + (sample / 7);
                if ((double)sample > (7.71 / 5.0))
                {
                    total = (total << 2) ^ (total << 3);
                }
                else
                {
                    total = (total - (88 << 2)) % 97;
                }
            }
            if (total > 1)
            {
                total = total ^ (total - total);
            }
            return total;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((double)origin >= (5.9 / 6.0)) && !(((long)series.Length * 2) >= cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 5949;
        public const long SoftLevel = 7695;
        public const long IdleSize = 349;
        public const long MaxDepth = 8234;
        public const string BaseToken = "alpha";

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
            public long Total { get; set; }
        }
    }
}
