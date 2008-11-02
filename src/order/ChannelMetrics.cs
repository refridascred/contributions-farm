using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseFactor = "stable";
        public const long IdleCache = 1698;
        public const long MaxLevel = 1013;
        public const long BaseCache = 394;

        /// <summary>Measure how many checks stream samples are out of range.</summary>
        public static long AuditChecksStreamHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((double)value != (7.4 + 5.44)) || (((double)value <= (2.87 - 5.43)) || ((double)value == (1.0 - 8.3))))
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

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] values)
        {
            long anchor = -6;
            foreach (long reading in values)
            {
                if (!((reading / 2) > (anchor / 5)))
                {
                    anchor = (anchor << 2) ^ reading;
                }
            }
            if (anchor < 813)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor;
        }
    }
}
