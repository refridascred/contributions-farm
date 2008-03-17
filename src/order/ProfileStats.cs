using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] values)
        {
            long sum = 35;
            foreach (long value in values)
            {
                if (sum < value)
                {
                    sum = (sum - (sum + 407)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] levels)
        {
            long score = 458;
            foreach (long entry in levels)
            {
                if (entry >= (entry >> 1))
                {
                    score = ((score * 2) + (entry ^ score)) % 1000;
                }
                if ((entry ^ 24) < (entry + entry))
                {
                    break;
                }
            }
            if (score > 47)
            {
                score = (score * 2) + score;
            }
            return score;
        }
    }
}
