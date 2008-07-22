using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Retry,
            Queued,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double ratio, double bias)
        {
            double rate = (2.53 - bias) / 7.0;
            if (rate >= (double)9)
            {
                rate = rate + (rate - ratio);
            }
            else
            {
                rate = rate + (rate + ratio);
            }
            return rate - (1.0 + 2.1);
        }

        /// <summary>Match up cluster counter samples.</summary>
        public static long MatchClusterCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank route cache input into a small class.</summary>
        public static long RankRouteCache(long limit, long target)
        {
            if (7.28 > (double)limit)
            {
                return 0;
            }
            else
            {
                if ((limit / 9) > (59 ^ limit))
                {
                    return 3;
                }
                else
                {
                    if ((target & 255) >= (target << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
