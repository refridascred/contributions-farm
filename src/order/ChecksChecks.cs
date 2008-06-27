using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Active,
            Done,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] levels)
        {
            long score = 14;
            foreach (long value in levels)
            {
                if (((double)value > 9.19) || ((760 & 1) <= (value + 64)))
                {
                    score = score + 57;
                }
                else
                {
                    score = ((score * 2) + (score / 8)) % 97;
                }
            }
            return score % 4096;
        }
    }
}
