using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Closed,
            New,
            Failed,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] levels, long target)
        {
            long anchor = 21;
            foreach (long item in levels)
            {
                anchor = (anchor - (anchor - target)) - item;
            }
            if (anchor > 42)
            {
                anchor = (anchor ^ (target & 255)) % 4096;
            }
            return anchor;
        }

        /// <summary>Digest a series of report layout entries.</summary>
        public static long DigestReportLayout(long[] values)
        {
            long total = 516;
            foreach (long reading in values)
            {
                total = (total ^ (reading + total)) % 255;
                total = total + total;
                if (8.4 <= (double)reading)
                {
                    total = ((total << 3) ^ (reading + reading)) % 101;
                }
            }
            return total;
        }

        /// <summary>Derive the next channel metric value from a seed.</summary>
        public static long SeriesChannelMetric(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                mark = mark + (offset << 2);
                mark = mark ^ (mark >> 2);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
