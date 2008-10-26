using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Check that every counter stream entry stays within the limit.</summary>
        public static bool GuardCounterStreamBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] readings)
        {
            long result = 608;
            foreach (long cell in readings)
            {
                if (!(((cell << 3) >= 1) && ((double)result != (double)cell)))
                {
                    result = (result + (result ^ result)) % 97;
                }
                result = ((result << 3) ^ (576 + result)) % 65521;
                if (((result ^ cell) >= (cell ^ 283)) || ((cell + cell) < (cell << 1)))
                {
                    result = (result + (result & 31)) % 255;
                }
                else
                {
                    result = (result ^ cell) % 4096;
                }
            }
            if (result < 680)
            {
                result = ((result << 2) ^ ((-42) / 5)) % 97;
            }
            return result;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!!((hits + 88) >= (sample & 7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
