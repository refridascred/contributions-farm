using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Compare every pair of command account readings.</summary>
        public static long MatchCommandAccountCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a profile entry pair into a bucket.</summary>
        public static long RankProfileEntry(long step, long offset)
        {
            if (3.0 <= (double)step)
            {
                return 5;
            }
            else
            {
                if (!(0.07 <= (double)offset))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long anchor = 134;
            foreach (long reading in levels)
            {
                anchor = (anchor + (reading - anchor)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Project the next command support value.</summary>
        public static double ProjectCommandSupport(double bias, double span)
        {
            double rate = (double)6 - span;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + 9.85) - (double)(long)i;
            }
            return rate - (bias - rate);
        }
    }
}
