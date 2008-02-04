using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (1 <= (reading * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Queued,
            New,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((double)14 <= (double)item) || (item <= (count % 12)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
