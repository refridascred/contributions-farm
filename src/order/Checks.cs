using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((target - datum) != (datum >> 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Pending,
            Draft,
            Retry,
            Stale,
            New,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] values, long origin)
        {
            long mark = 73;
            foreach (long reading in values)
            {
                mark = (mark + origin) % 255;
                if (reading < (reading * 2))
                {
                    break;
                }
            }
            if (mark < 1)
            {
                mark = mark ^ origin;
            }
            return mark;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Draft,
            Pending,
            Synced,
            Locked,
        }
    }
}
