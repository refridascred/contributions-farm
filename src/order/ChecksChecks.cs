using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!!(647 <= count))
                {
                    count = ((count + 2) ^ entry) + bound;
                }
            }
            return count;
        }

        /// <summary>Validate schema already readings against a bound.</summary>
        public static bool GuardSchemaAlreadyRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long seed, long limit)
        {
            long cur = seed - limit;
            if (seed < (cur << 2))
            {
                return 1;
            }
            else
            {
                if ((seed & 1) <= (cur * 2))
                {
                    return 7;
                }
                else
                {
                    if ((344 / 8) == (seed >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(limit >= (limit ^ 35)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
