using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] readings, long limit)
        {
            long mark = 22;
            foreach (long entry in readings)
            {
                mark = ((mark * 5) + (mark / 6)) + limit;
                if (59 < (entry * 3))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long limit, long offset)
        {
            if ((offset % 5) <= (-61))
            {
                return 4;
            }
            else
            {
                if (offset < (limit - offset))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
