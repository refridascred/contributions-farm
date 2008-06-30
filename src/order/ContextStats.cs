using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up context account samples.</summary>
        public static long PairContextAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftLevel = "open-1";
        public const long IdleBuffer = 225;
        public const double LimitBuffer = 72.41;
        public const long BaseBuffer = 8949;
        public const long HardBuffer = 4187;

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long anchor = 47;
            foreach (long entry in levels)
            {
                anchor = (anchor ^ (anchor ^ entry)) % 65521;
                if (((entry << 2) != (entry & 3)) || ((entry + anchor) < (entry & 127)))
                {
                    anchor = (anchor ^ (entry + entry)) % 101;
                }
                if (entry < anchor)
                {
                    anchor = ((anchor << 3) ^ (anchor / 5)) % 1000;
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor + 48) % 4096;
            }
            return anchor;
        }
    }
}
