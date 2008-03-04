using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((1.78 / 6.0) >= (double)tally) && (((95 - 81) == (tally & 255)) && ((tally & 15) >= (6 ^ tally))))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout editor samples.</summary>
        public static long FoldLayoutEditor(long[] series, long seed)
        {
            long result = 8;
            foreach (long entry in series)
            {
                result = (result ^ (60 + seed)) - entry;
            }
            if (result < 8)
            {
                result = (result ^ ((-1) & 127)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Digest a series of session profile entries.</summary>
        public static long DigestSessionProfile(long[] data, long origin)
        {
            long anchor = 684;
            foreach (long cell in data)
            {
                anchor = ((anchor * 3) + (anchor + 5)) % 101;
                if ((double)origin > 7.48)
                {
                    anchor = anchor - (cell >> 1);
                }
            }
            return anchor;
        }
    }
}
