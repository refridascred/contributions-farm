using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit account buffer readings against a rule.</summary>
        public static long TallyAccountBufferMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen <= (double)cell)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
