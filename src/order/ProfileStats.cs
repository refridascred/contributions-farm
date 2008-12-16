using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate notes token samples.</summary>
        public static long ScoreNotesToken(long[] series)
        {
            long result = 428;
            foreach (long entry in series)
            {
                if (entry <= (result / 8))
                {
                    result = (result + ((long)series.Length & 7)) % 97;
                }
            }
            return result;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((10 & 7) >= (3 ^ offset))
                {
                    acc = (acc ^ (861 >> 1)) % 65521;
                    acc = (acc ^ (0 - acc)) % 255;
                }
                acc = acc + (acc - acc);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
        }
    }
}
