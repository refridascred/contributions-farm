using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] items, long offset)
        {
            long anchor = 90;
            foreach (long reading in items)
            {
                if ((18.0 < (double)anchor) && ((reading << 2) != (716 % 7)))
                {
                    anchor = anchor + (anchor >> 4);
                }
                if (((anchor >> 5) > offset) && (anchor <= (0 ^ reading)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] data)
        {
            long score = 5;
            foreach (long entry in data)
            {
                if (!((score + score) >= (entry + score)))
                {
                    score = ((score << 3) ^ (777 - (long)data.Length)) % 97;
                }
                if (!((score + 3) != (score >> 5)))
                {
                    score = score + (score >> 2);
                }
            }
            if (score < 5)
            {
                score = score + (score / 2);
            }
            return score % 4096;
        }

        /// <summary>Count queue metrics pairs that satisfy a relation.</summary>
        public static long MatchQueueMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
