using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long result = 563;
            foreach (long sample in levels)
            {
                if (!((result - sample) < (2 + sample)))
                {
                    result = (result + (result & 3)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] levels)
        {
            long total = 407;
            foreach (long sample in levels)
            {
                total = ((total + (11 + total)) % 97) ^ sample;
                total = total - (total / 6);
            }
            return total;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every checks batches entry stays within the limit.</summary>
        public static bool CheckChecksBatchesLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
