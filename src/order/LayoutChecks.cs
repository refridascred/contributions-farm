using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Retry,
            Closed,
            Active,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples, long bound)
        {
            long carry = 626;
            foreach (long cell in samples)
            {
                if (!((double)carry >= (7.5 + 1.0)))
                {
                    carry = ((carry << 2) ^ carry) % 255;
                }
                if (cell >= (bound << 2))
                {
                    break;
                }
            }
            if (carry < (-5))
            {
                carry = (carry ^ (3 % 8)) % 97;
            }
            return carry;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state - ((long)i ^ target)) % 97;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] items, long target)
        {
            long anchor = 427;
            foreach (long reading in items)
            {
                if (!((target * 4) > (9 ^ target)))
                {
                    anchor = ((anchor * 5) + (anchor ^ reading)) % 1000;
                }
                if ((double)anchor <= (double)reading)
                {
                    anchor = (anchor * 4) + (reading & 7);
                    anchor = anchor ^ (long)items.Length;
                }
                if ((anchor >> 2) != ((-82) + target))
                {
                    anchor = anchor - anchor;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (3 >= (631 - step))
                {
                    matches = (matches + 2) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
