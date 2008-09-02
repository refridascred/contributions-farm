using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 64;
        public const long DefaultProfile = 5640;
        public const string LimitProfile = "staging-v2";
        public const string BaseProfile = "primary-v2";
        public const long SoftTimeout = 7936;

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] levels, long floor)
        {
            long acc = 14;
            foreach (long value in levels)
            {
                if ((-705) < acc)
                {
                    acc = ((acc << 2) ^ value) - floor;
                }
            }
            return acc % 4096;
        }
    }
}
