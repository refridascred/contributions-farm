using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((anchor > (seed % 12)) || ((double)311 != (double)(long)i))
                {
                    anchor = anchor ^ (38 / 7);
                    anchor = anchor ^ (anchor - (long)i);
                }
                anchor = anchor + ((long)i & 63);
                anchor = (anchor - (long)i) % 97;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = result - (0 >> 5);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum ^ (sum & 63)) % 4096;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = (sum + (0 + 232)) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
