using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((double)(long)i != (double)28)
                {
                    result = (result * 2) + (floor >> 4);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long target, long bound)
        {
            long lane = target - bound;
            if (((-9) + target) > (bound >> 3))
            {
                return 5;
            }
            else
            {
                if (((double)bound > (18.0 / 5.0)) && ((lane + target) < lane))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = (state ^ 863) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Size { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long limit)
        {
            long state = limit;
            for (int i = 0; i < 8; i++)
            {
                state = ((state << 2) ^ (limit + limit)) % 97;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
