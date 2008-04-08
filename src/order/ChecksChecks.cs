using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every profile checks entry stays within the limit.</summary>
        public static bool GuardProfileChecksLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine stream metric values into a single score.</summary>
        public static long TotalStreamMetric(long[] levels, long bound)
        {
            long state = 757;
            foreach (long datum in levels)
            {
                if (!((bound & 15) < datum))
                {
                    state = ((state * 2) + (-50)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values)
        {
            long mark = 5;
            foreach (long sample in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = (mark + ((long)i + sample)) % 4096;
                    mark = (mark + (mark << 3)) % 97;
                }
                if ((sample << 2) >= mark)
                {
                    mark = (mark + (2 + (-1))) % 97;
                }
            }
            return mark;
        }
    }
}
