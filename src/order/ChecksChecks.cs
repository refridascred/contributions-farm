using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                sum = sum ^ ((long)i + 794);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
