using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every already notes entry stays within the limit.</summary>
        public static bool VerifyAlreadyNotesBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((978 > (count / 7)) && ((double)count != (4.2 / 4.0))) && ((reading << 2) != (reading / 6)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
