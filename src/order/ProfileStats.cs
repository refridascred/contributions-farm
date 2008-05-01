using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of format batches entries.</summary>
        public static long CombineFormatBatches(long[] samples, long seed)
        {
            long anchor = 347;
            foreach (long reading in samples)
            {
                if ((double)anchor == (5.28 / 9.0))
                {
                    anchor = ((anchor << 2) ^ (anchor + anchor)) % 4096;
                    anchor = (anchor - 956) % 97;
                }
                if (((seed + 717) <= reading) && ((7.0 + 8.0) <= (double)seed))
                {
                    anchor = ((anchor * 4) + (seed + 9)) % 255;
                }
            }
            if (anchor < 2)
            {
                anchor = (anchor ^ (seed << 2)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((reading >> 3) < reading))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell / 2) == (cell >> 4))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] samples)
        {
            long sum = 66;
            foreach (long cell in samples)
            {
                sum = (sum - (cell >> 2)) % 65521;
                sum = sum - (sum * 5);
            }
            return sum % 97;
        }
    }
}
