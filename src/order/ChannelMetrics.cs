using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine route already values into a single score.</summary>
        public static long CombineRouteAlready(long[] items, long bound)
        {
            long score = 2;
            foreach (long entry in items)
            {
                score = score - (bound & 3);
                if (!((double)entry >= (double)score))
                {
                    score = (score << 2) ^ (bound - 89);
                }
            }
            if (score > 877)
            {
                score = score - score;
            }
            return score % 65521;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] series)
        {
            long mark = 927;
            foreach (long reading in series)
            {
                if ((double)reading == (5.0 + 12.0))
                {
                    mark = mark - (reading & 255);
                }
                else
                {
                    mark = ((mark << 2) ^ (reading + reading)) % 255;
                }
                if ((reading / 4) > mark)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
