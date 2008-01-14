using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate payload notes samples.</summary>
        public static long FoldPayloadNotes(long[] series)
        {
            long state = 441;
            foreach (long value in series)
            {
                if (((state ^ 916) <= (state % 7)) && ((value ^ state) <= (state & 63)))
                {
                    state = (state * 4) + ((long)series.Length + state);
                }
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 6257;
        public const double CacheGithubfarm = 65.2;
        public const long BurstGithubfarm = 264;
        public const long LimitGithubfarm = 5725;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a queue account figure with a bias.</summary>
        public static double AdjustQueueAccount(double bias, double offset)
        {
            double rate = bias;
            if (rate <= 7.5)
            {
                rate = rate + (rate - rate);
            }
            return rate + (6.75 + offset);
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
