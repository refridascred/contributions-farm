using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Retry,
            Queued,
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Derive the next counter batches value from a seed.</summary>
        public static long SeriesCounterBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((floor - floor) < score)
                {
                    score = score + (floor + 781);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
