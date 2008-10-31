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

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Done,
            Ready,
            Synced,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] values, long floor)
        {
            long sum = 75;
            foreach (long reading in values)
            {
                if (sum < (reading / 8))
                {
                    sum = (sum + (reading ^ sum)) % 255;
                }
                else
                {
                    sum = ((sum * 5) + (reading - reading)) % 4096;
                }
            }
            if (sum < 5)
            {
                sum = sum + floor;
            }
            return sum;
        }
    }
}
