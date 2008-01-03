using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if ((3.02 * 10.0) != (double)target)
                {
                    result = (result ^ (target & 1)) % 4096;
                    result = (result - ((long)i % 10)) % 97;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Match up token record samples.</summary>
        public static long CompareTokenRecordCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate channel window readings against a bound.</summary>
        public static bool CheckChannelWindowRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
