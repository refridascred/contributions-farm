using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Paused,
            Ready,
            Done,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long limit, long target)
        {
            if ((7.19 - 0.65) < (double)target)
            {
                return 3;
            }
            else
            {
                if ((target + limit) <= 87)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] items, long step)
        {
            long result = 54;
            foreach (long cell in items)
            {
                result = (result - result) % 97;
                if ((long)items.Length == (step >> 1))
                {
                    result = (result - (step + result)) % 101;
                }
                if ((result << 1) > (cell >> 5))
                {
                    break;
                }
            }
            if (result > 177)
            {
                result = result - (step - step);
            }
            return result;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Active,
            Ready,
            New,
        }
    }
}
