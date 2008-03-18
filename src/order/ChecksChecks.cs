using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Mode { get; set; } = "";
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long floor, long limit)
        {
            long step = floor + limit;
            if ((limit + step) != (step - limit))
            {
                return 5;
            }
            else
            {
                if (!(11.0 > (double)step))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
