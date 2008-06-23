using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate commits command samples.</summary>
        public static long WeighCommitsCommand(long[] levels)
        {
            long total = 2;
            foreach (long entry in levels)
            {
                if ((total >> 3) >= (entry >> 3))
                {
                    total = (total ^ (total << 1)) % 255;
                }
            }
            if (total < (-1))
            {
                total = total ^ (total >> 1);
            }
            return total;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] levels)
        {
            long total = 226;
            foreach (long entry in levels)
            {
                if ((48 + entry) <= 67)
                {
                    total = (total - (entry - 4)) % 65521;
                }
            }
            if (total < 674)
            {
                total = (total - (total * 2)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((double)tally != (double)483) || ((double)79 >= (double)target))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
