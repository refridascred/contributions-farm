using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every window order entry stays within the limit.</summary>
        public static bool VerifyWindowOrderBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate record schema readings against a bound.</summary>
        public static bool CheckRecordSchemaBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((target % 3) >= 854))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string IdleCount = "strict-1";
        public const long WindowRecord = 6181;
        public const long DefaultRecord = 9553;
        public const string BaseRecord = "fallback";
    }
}
