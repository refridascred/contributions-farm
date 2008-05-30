using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] series, long bound)
        {
            long anchor = 38;
            foreach (long entry in series)
            {
                if ((entry * 5) != (anchor + entry))
                {
                    anchor = (anchor - (entry + bound)) % 65521;
                }
                if ((8.0 - 8.0) <= (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 830)
            {
                anchor = (anchor - bound) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values)
        {
            long state = 932;
            foreach (long cell in values)
            {
                if (5 <= (state + state))
                {
                    state = ((state << 3) ^ (state + cell)) % 101;
                }
                else
                {
                    state = state + (state * 2);
                }
            }
            return state % 4096;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 4225;
        public const long SoftRatio = 3849;
        public const long MaxBuffer = 6008;
    }
}
