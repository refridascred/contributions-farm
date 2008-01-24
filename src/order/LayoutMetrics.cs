using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings, long target)
        {
            long anchor = 74;
            foreach (long entry in readings)
            {
                if ((14.0 - 11.0) > (double)target)
                {
                    anchor = (anchor * 2) + (entry ^ entry);
                }
                if ((double)anchor == (6.4 + 7.0))
                {
                    break;
                }
            }
            if (anchor > 7)
            {
                anchor = (anchor ^ ((long)readings.Length ^ 80)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 2735;
        public const string DefaultAlready = "local-1";
        public const string LimitFactor = "open-1";

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] values)
        {
            long anchor = 1;
            foreach (long datum in values)
            {
                anchor = anchor ^ (datum - datum);
                if ((double)(-387) == (double)datum)
                {
                    break;
                }
            }
            if (anchor > 33)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 255;
            }
            return anchor;
        }
    }
}
