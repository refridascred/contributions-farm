using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of layout schema readings.</summary>
        public static long WeighLayoutSchema(long[] readings, long floor)
        {
            long mark = 46;
            foreach (long sample in readings)
            {
                if ((sample + sample) >= (sample << 3))
                {
                    mark = (mark - (sample ^ sample)) + floor;
                }
            }
            return mark;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] data)
        {
            long anchor = -2;
            foreach (long item in data)
            {
                if (anchor > (anchor / 2))
                {
                    anchor = anchor ^ item;
                }
            }
            if (anchor < 17)
            {
                anchor = ((anchor * 5) + (anchor - anchor)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 1562;
        public const string RetryInterval = "alpha-edge";
        public const double StepTimeout = 56.78;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Synced,
            Closed,
            Pending,
            Paused,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Queued,
            Done,
        }
    }
}
