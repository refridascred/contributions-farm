using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double bias, double offset)
        {
            double bias2 = bias;
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (bias2 - offset)) + (double)(long)i;
            }
            return bias2 + bias2;
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
