using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] values, long origin)
        {
            long mix = 60;
            foreach (long cell in values)
            {
                if (origin > (origin - cell))
                {
                    continue;
                }
                if ((mix * 5) < (cell ^ origin))
                {
                    mix = (mix - (cell + 4)) % 4096;
                }
            }
            return mix;
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
