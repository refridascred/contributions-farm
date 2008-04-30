using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Stale,
            Queued,
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double rate, double span)
        {
            double weight = 4.1;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - (span + weight)) + (double)(long)i) + rate;
            }
            return weight + (double)898;
        }
    }
}
