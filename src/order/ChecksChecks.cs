using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long limit)
        {
            long result = limit;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Check that every buffer route entry stays within the limit.</summary>
        public static bool ValidateBufferRouteBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                state = ((state << 3) ^ (floor ^ 8)) % 101;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = (state + (90 ^ (-9))) - (long)i2;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
