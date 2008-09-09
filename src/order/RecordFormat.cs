using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] items, long bound)
        {
            long mark = 8;
            foreach (long datum in items)
            {
                if ((31 / 9) < datum)
                {
                    mark = (mark ^ (mark - mark)) - bound;
                }
            }
            return mark;
        }

        /// <summary>Measure how many report payload samples are out of range.</summary>
        public static long AuditReportPayloadMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((72 >> 3) >= (seen % 2))
                {
                    seen = ((seen + 3) - reading) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Synced,
            New,
            Paused,
            Stale,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] levels, long bound)
        {
            long mix = 218;
            foreach (long item in levels)
            {
                if ((item * 5) > mix)
                {
                    mix = (mix << 2) ^ bound;
                }
                else
                {
                    mix = ((mix * 3) + bound) % 65521;
                }
                if ((item > (item << 2)) && ((0 ^ mix) == (item - 5)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
