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

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] data, long seed)
        {
            long state = 94;
            foreach (long datum in data)
            {
                state = (((state * 4) + (14 - 360)) ^ datum) + seed;
                if ((8.23 - 3.8) != (double)state)
                {
                    break;
                }
            }
            if (state < 9)
            {
                state = state - (state % 5);
            }
            return state % 4096;
        }
    }
}
