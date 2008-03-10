using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine window commits values into a single score.</summary>
        public static long TotalWindowCommits(long[] readings, long floor)
        {
            long result = 2;
            foreach (long reading in readings)
            {
                if ((floor >> 2) > (reading >> 2))
                {
                    result = ((result << 3) ^ ((-70) % 5)) % 255;
                }
                else
                {
                    result = (result - (result << 2)) % 97;
                }
                if ((floor >> 3) >= (result & 7))
                {
                    break;
                }
            }
            if (result > 862)
            {
                result = (result << 3) ^ floor;
            }
            return result % 4096;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
