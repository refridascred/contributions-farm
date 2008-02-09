using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Done,
            Retry,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels, long offset)
        {
            long mark = 2;
            foreach (long sample in levels)
            {
                if (!((sample - sample) <= (33 % 2)))
                {
                    mark = (((mark * 2) + (mark * 3)) % 65521) - offset;
                }
            }
            return mark % 97;
        }
    }
}
