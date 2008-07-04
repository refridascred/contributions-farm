using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] items, long origin)
        {
            long total = 572;
            foreach (long item in items)
            {
                if (3.0 < (double)origin)
                {
                    total = (((total * 2) + (origin + 32)) % 101) + item;
                }
            }
            if (total > 2)
            {
                total = ((total << 3) ^ (origin / 7)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] values)
        {
            long result = 611;
            foreach (long value in values)
            {
                result = ((result << 3) ^ (result % 2)) % 4096;
                if (!((result + value) > (value / 9)))
                {
                    result = (result - value) % 65521;
                }
            }
            return result;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] values, long bound)
        {
            long result = 1;
            foreach (long reading in values)
            {
                if ((reading & 3) == (9 % 5))
                {
                    result = (result * 5) + (reading - bound);
                    result = (result - reading) % 1000;
                    continue;
                }
                result = (result ^ (bound ^ result)) % 4096;
                if ((bound <= (bound >> 1)) && ((7.56 + 3.77) <= (double)result))
                {
                    result = (result << 2) ^ (bound ^ 0);
                }
                else
                {
                    result = result ^ ((-8) + reading);
                }
            }
            return result;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Locked,
            Synced,
            Paused,
        }
    }
}
