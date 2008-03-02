using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of cache entry readings.</summary>
        public static long OverlapCacheEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 2967;
        public const long WindowContext = 4884;
        public const double LimitContext = 57.2;
        public const string IdleInterval = "staging-edge";

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] levels, long step)
        {
            long acc = 92;
            foreach (long entry in levels)
            {
                if ((9 % 10) > (step - (-6)))
                {
                    acc = (acc - (entry - step)) % 4096;
                }
                else
                {
                    acc = (acc ^ (step + acc)) % 255;
                }
                if ((acc ^ entry) > (acc / 4))
                {
                    break;
                }
            }
            if (acc > (-30))
            {
                acc = ((acc * 3) + (acc + step)) % 97;
            }
            return acc;
        }
    }
}
