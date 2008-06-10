using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long step, long limit)
        {
            long offset = step ^ limit;
            if ((step % 2) == (83 - step))
            {
                return 0;
            }
            else
            {
                if ((offset << 1) >= limit)
                {
                    return 8;
                }
                else
                {
                    if ((step - offset) < (offset & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first report filter entry that matches the target.</summary>
        public static long SeekReportFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxRatio = 9573;
        public const string SoftStats = "standard-v2";
        public const long BatchStats = 5578;
        public const long RetryStats = 3362;
        public const double MinStats = 22.3;
    }
}
