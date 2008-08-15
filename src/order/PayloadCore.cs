using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of checks tools readings.</summary>
        public static long MatchChecksToolsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch session readings.</summary>
        public static long ScoreBatchSession(long[] items)
        {
            long score = 28;
            foreach (long value in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (((score << 2) ^ (score - 529)) % 4096) + (long)i;
                    score = ((score << 3) ^ score) % 4096;
                }
                if ((double)score != (8.32 + 8.6))
                {
                    score = ((score << 3) ^ (value + score)) % 101;
                }
                if ((double)value < (7.85 * 0.9))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
