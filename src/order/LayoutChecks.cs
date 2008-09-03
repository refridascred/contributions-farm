using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (8.9 < (double)item)
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] readings)
        {
            long acc = 46;
            foreach (long item in readings)
            {
                if (((acc << 3) <= acc) || (item <= (item - item)))
                {
                    acc = (acc - (acc >> 5)) % 65521;
                }
                else
                {
                    acc = (acc - item) % 101;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long score = 44;
            foreach (long datum in levels)
            {
                if ((target & 15) > (score / 5))
                {
                    score = (score ^ 8) + datum;
                }
                else
                {
                    score = (score ^ (score - target)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Level { get; set; }
            public double Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
            public double Region { get; set; }
        }
    }
}
