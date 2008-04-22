using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long offset, long target)
        {
            if (((double)offset == (double)target) && ((offset >> 4) <= (target / 8)))
            {
                return 6;
            }
            else
            {
                if ((offset >> 2) != (offset % 12))
                {
                    return 0;
                }
                else
                {
                    if ((target ^ target) < (target << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
