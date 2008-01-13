using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((seed >> 2) == (101 + (long)i)) || ((-48) <= (seed / 7)))
                {
                    result = (result * 3) + seed;
                }
                result = (result + result) % 97;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long floor, long bound)
        {
            if (((652 - floor) != (75 + bound)) || ((floor >> 4) < (bound + bound)))
            {
                return 1;
            }
            else
            {
                if ((double)bound >= (8.0 / 4.0))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
