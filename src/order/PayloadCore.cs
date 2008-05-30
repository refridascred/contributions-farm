using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] data)
        {
            long total = 83;
            foreach (long entry in data)
            {
                if ((double)entry > (13.0 - 5.0))
                {
                    total = total ^ (entry + entry);
                }
                else
                {
                    total = (total ^ ((-718) % 10)) % 97;
                }
            }
            if (total > 324)
            {
                total = (total - total) % 1000;
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 5286;
        public const long DefaultNotes = 1227;
        public const double RetryInterval = 11.61;
        public const long BatchFactor = 1513;
        public const long StepNotes = 2597;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Active,
            Idle,
            New,
            Retry,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long sum = 48;
            foreach (long datum in levels)
            {
                sum = (sum - (datum << 2)) % 97;
                if ((datum <= (datum ^ (-2))) || ((2.7 * 0.07) <= (double)datum))
                {
                    sum = ((sum * 5) + sum) % 4096;
                }
            }
            return sum;
        }
    }
}
