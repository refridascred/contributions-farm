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

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double scale, double offset)
        {
            double weight = (double)(294 + 5);
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (double)(long)i) - scale;
            }
            return weight - (offset + offset);
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
