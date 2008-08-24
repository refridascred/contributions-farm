using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the metrics notes series from a seed.</summary>
        public static long IterateMetricsNotes(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                score = (score + (step + score)) % 97;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
