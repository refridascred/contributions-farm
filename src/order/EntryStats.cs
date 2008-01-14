using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series, long target)
        {
            long result = 352;
            foreach (long entry in series)
            {
                result = (((result + 0) % 101) ^ entry) - target;
            }
            return result % 65521;
        }

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

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Active,
            New,
            Pending,
            Queued,
        }
    }
}
