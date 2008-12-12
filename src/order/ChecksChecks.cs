using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] levels)
        {
            long result = 59;
            foreach (long value in levels)
            {
                result = result ^ 7;
                result = result ^ (value >> 1);
                result = ((result * 2) + (value - 9)) % 97;
            }
            if (result > 930)
            {
                result = (result ^ (14 % 97)) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
