using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long bound, long offset)
        {
            if ((double)offset == (19.0 / 6.0))
            {
                return 8;
            }
            else
            {
                if ((bound + offset) == (bound + 5))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound >= (6.0 * 0.49))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample + (long)samples.Length) < sample)
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Locked,
            Failed,
            New,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }
    }
}
