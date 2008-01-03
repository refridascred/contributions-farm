using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseScore = 5964;
        public const long MinBatches = 5865;
        public const long StepDepth = 1482;
        public const string HardSize = "stable-edge";

        /// <summary>Look up the position of a buffer command sample.</summary>
        public static long LookupBufferCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((0 < (entry & 31)) && ((count ^ entry) <= 111)) || ((count >> 5) <= (entry / 3)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Score { get; set; }
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] readings, long bound)
        {
            long acc = -8;
            foreach (long cell in readings)
            {
                if (bound < (bound + cell))
                {
                    acc = (acc << 2) ^ (acc << 3);
                }
                else
                {
                    acc = acc ^ acc;
                }
            }
            if (acc < 696)
            {
                acc = (acc * 3) + (acc ^ bound);
            }
            return acc;
        }
    }
}
