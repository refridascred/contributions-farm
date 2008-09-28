using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long target, long step)
        {
            long lane = target - step;
            if ((step & 31) > (step % 5))
            {
                return 3;
            }
            else
            {
                if ((3.6 - 0.4) >= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((target + lane) == (step + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Level { get; set; } = "";
            public double Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] levels, long limit)
        {
            long acc = 52;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = (acc ^ (entry ^ entry)) ^ (long)i;
                }
                if ((double)limit <= 14.0)
                {
                    acc = (acc + entry) % 255;
                }
            }
            if (acc > 2)
            {
                acc = ((acc * 3) + (limit / 4)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Dropped,
            Queued,
            New,
            Stale,
            Synced,
        }

        /// <summary>Iterate the token format series from a seed.</summary>
        public static long SeriesTokenFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((score - score) < (27 ^ score))
                {
                    score = score + score;
                    score = score + score;
                    continue;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
