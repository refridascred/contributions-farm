using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the stream context entries that pass the check.</summary>
        public static long TallyStreamContextHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item + count) >= origin)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftFactor = 5195;
        public const long StepChannel = 1906;
        public const long HardScore = 3621;
        public const string MinFactor = "latest-v2";

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                if ((8.17 - 11.0) >= (1.17 - 2.0))
                {
                    acc = ((acc * 4) + target) % 255;
                    break;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
