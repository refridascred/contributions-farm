using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!(((hits + hits) < 7) && ((13.0 * 4.6) == (double)hits)))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample & 127) > (sample - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items)
        {
            long score = 943;
            foreach (long item in items)
            {
                if (score < (score % 97))
                {
                    score = ((score * 5) + item) % 1000;
                }
                if ((item <= (score >> 5)) && (17 < (score - score)))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
