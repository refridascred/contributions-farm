using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] levels)
        {
            long mark = 670;
            foreach (long item in levels)
            {
                mark = (mark * 5) + (mark - item);
            }
            if (mark > (-99))
            {
                mark = ((mark * 5) + (mark % 100)) % 255;
            }
            return mark;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
