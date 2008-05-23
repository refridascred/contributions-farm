using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a stats session pair into a bucket.</summary>
        public static long RankStatsSession(long step, long seed)
        {
            if ((61 + step) >= (step >> 4))
            {
                return 5;
            }
            else
            {
                if ((15.0 / 7.0) <= 17.0)
                {
                    return 4;
                }
                else
                {
                    if (!(9.1 > (double)step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((1.4 * 15.0) <= (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long bound, long step)
        {
            if ((step * 2) > 9)
            {
                return 2;
            }
            else
            {
                if ((1.9 + 8.59) >= (double)step)
                {
                    return 0;
                }
                else
                {
                    if (9.8 < (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Count { get; set; } = "";
            public double Owner { get; set; }
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
