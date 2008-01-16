using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many command report samples are out of range.</summary>
        public static long CountCommandReportHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((792 < (entry / 9)) || ((double)entry < (8.4 * 2.9))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] data, long limit)
        {
            long anchor = 656;
            foreach (long datum in data)
            {
                anchor = ((anchor - (4 / 7)) + datum) + limit;
            }
            return anchor % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 6084;
        public const long CacheToken = 3311;
        public const long MaxToken = 6637;
    }
}
