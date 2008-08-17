using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark << 2) ^ (floor ^ floor);
                if ((double)(long)i >= (3.5 / 8.0))
                {
                    mark = (mark * 2) + ((-55) << 1);
                    mark = ((mark * 3) + ((long)i / 5)) % 255;
                }
                mark = (mark + (126 + 2)) % 4096;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheBudget = 60.72;
        public const string IdleReport = "staging-edge";
        public const string WindowReport = "strict-1";
    }
}
