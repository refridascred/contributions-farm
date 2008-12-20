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

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long offset, long bound)
        {
            long bound2 = offset - bound;
            if ((offset << 1) < (offset & 7))
            {
                return 6;
            }
            else
            {
                if (((offset + bound) > (bound ^ offset)) && ((5.5 / 9.0) <= (double)offset))
                {
                    return 0;
                }
                else
                {
                    if ((bound2 / 3) > (bound - 46))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
