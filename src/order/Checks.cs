using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Pending,
            Synced,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (datum < (datum % 60))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double ratio, double span)
        {
            double rate = (double)((-79) ^ 337);
            if (rate < span)
            {
                rate = rate - span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - ratio) + (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            New,
            Queued,
            Closed,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            New,
            Queued,
            Stale,
        }
    }
}
