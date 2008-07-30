using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long result = 95;
            foreach (long item in levels)
            {
                if (result > (result + 930))
                {
                    result = (((result * 3) + (37 + 666)) % 1000) - item;
                }
            }
            return result;
        }

        /// <summary>Validate stats editor readings against a bound.</summary>
        public static bool ValidateStatsEditorBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first support farm entry that matches the target.</summary>
        public static long SeekSupportFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a report already counter forward.</summary>
        public static long SeriesReportAlready(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark << 3) ^ (mark << 3);
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
