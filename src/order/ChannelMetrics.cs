using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long step, long limit)
        {
            long gap = step + limit;
            if (gap >= step)
            {
                return 5;
            }
            else
            {
                if ((step & 15) == (step + limit))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
