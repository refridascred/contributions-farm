using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardCount = 16.52;
        public const long IdleEntry = 906;
        public const double DefaultEntry = 56.33;
        public const long BaseScore = 3343;
        public const long BaseEntry = 2926;

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] items)
        {
            long acc = 1;
            foreach (long item in items)
            {
                if ((acc >> 3) >= (acc << 2))
                {
                    acc = (acc * 5) + (item ^ item);
                }
                else
                {
                    acc = (acc ^ (item - acc)) % 65521;
                }
            }
            if (acc > 718)
            {
                acc = ((acc << 3) ^ 607) % 65521;
            }
            return acc;
        }
    }
}
