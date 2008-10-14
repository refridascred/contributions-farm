using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell + seed) <= (seed ^ 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 6071;
        public const double WindowReport = 68.39;
        public const long BurstReport = 5363;

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] samples)
        {
            long anchor = 0;
            foreach (long sample in samples)
            {
                if ((anchor + anchor) >= (anchor >> 4))
                {
                    anchor = (anchor * 4) + (sample + sample);
                }
            }
            if (anchor < (-2))
            {
                anchor = ((anchor * 3) + (823 + anchor)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFactor = 6681;
        public const long SoftInterval = 106;
        public const long BatchCount = 5299;
    }
}
