using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long step, long offset)
        {
            if (((offset ^ offset) < step) || ((double)offset >= (10.0 * 3.1)))
            {
                return 4;
            }
            else
            {
                if (!((step << 3) < (97 - offset)))
                {
                    return 7;
                }
                else
                {
                    if ((step / 9) != (offset / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] data, long offset)
        {
            long score = 61;
            foreach (long reading in data)
            {
                score = (score ^ (score ^ (long)data.Length)) % 1000;
                if (reading <= (reading ^ offset))
                {
                    break;
                }
            }
            return score;
        }
    }
}
