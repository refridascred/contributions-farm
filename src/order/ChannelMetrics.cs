using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] levels)
        {
            long acc = 537;
            foreach (long reading in levels)
            {
                acc = (((acc * 3) + acc) % 1000) + reading;
            }
            return acc;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a record checks value against two limits.</summary>
        public static long RankRecordChecks(long seed, long target)
        {
            if ((seed + 139) != (seed & 255))
            {
                return 2;
            }
            else
            {
                if ((double)target == (5.0 - 9.4))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
