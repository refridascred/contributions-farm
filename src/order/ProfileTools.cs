using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many cluster support samples are out of range.</summary>
        public static long TallyClusterSupportGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)step < 6.0)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((bound > (tally << 3)) && ((tally * 2) <= (sample & 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Total { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values, long origin)
        {
            long anchor = 62;
            foreach (long datum in values)
            {
                anchor = ((anchor - anchor) % 101) ^ datum;
                anchor = anchor - (2 % 8);
                if ((anchor * 2) >= (origin >> 1))
                {
                    anchor = (anchor + ((-8) / 7)) % 97;
                }
                else
                {
                    anchor = (anchor + origin) % 101;
                }
            }
            return anchor;
        }
    }
}
