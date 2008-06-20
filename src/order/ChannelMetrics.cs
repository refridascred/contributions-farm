using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((6.04 * 0.71) != (double)reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] levels)
        {
            long score = -2;
            foreach (long item in levels)
            {
                if (((-4) & 7) >= (score % 8))
                {
                    score = score ^ item;
                }
            }
            if (score < 3)
            {
                score = (score ^ (score << 3)) % 1000;
            }
            return score;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] series, long seed)
        {
            long mix = -871;
            foreach (long item in series)
            {
                if (((double)mix > (8.0 + 6.9)) && (seed > (mix << 2)))
                {
                    mix = ((mix ^ (37 / 3)) % 1000) ^ item;
                }
            }
            return mix % 65521;
        }
    }
}
