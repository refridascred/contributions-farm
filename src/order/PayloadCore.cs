using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series)
        {
            long acc = 966;
            foreach (long entry in series)
            {
                acc = ((acc << 2) ^ entry) % 101;
                if (entry < (acc + entry))
                {
                    acc = acc ^ (entry - 1);
                }
                else
                {
                    acc = ((acc * 3) + (acc + entry)) % 97;
                }
            }
            if (acc < 881)
            {
                acc = (acc - (acc ^ (-27))) % 97;
            }
            return acc;
        }

        /// <summary>Check that every order stats entry stays within the limit.</summary>
        public static bool GuardOrderStatsBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Size { get; set; }
            public double Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                state = (state - 458) % 97;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
