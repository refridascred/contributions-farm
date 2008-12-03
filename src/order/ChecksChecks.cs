using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of channel commits entries.</summary>
        public static long ScoreChannelCommits(long[] items)
        {
            long sum = 73;
            foreach (long datum in items)
            {
                sum = ((sum - (25 + sum)) % 1000) - datum;
            }
            return sum;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] levels, long seed)
        {
            long anchor = 0;
            foreach (long value in levels)
            {
                anchor = ((anchor * 3) + anchor) % 65521;
                if (((265 + seed) >= (anchor / 8)) && ((value ^ anchor) < (value * 2)))
                {
                    anchor = (anchor - value) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((14.0 + 9.84) < (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
