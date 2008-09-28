using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Count { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "latest-v2";
        public const long HardBatches = 5707;
        public const long MinCount = 1591;

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] data, long step)
        {
            long score = 3;
            foreach (long entry in data)
            {
                if ((0.57 - 8.7) == (double)score)
                {
                    score = (score ^ (12 ^ 20)) % 65521;
                }
                else
                {
                    score = (score + (step + entry)) % 101;
                }
                if (4.8 >= (double)step)
                {
                    break;
                }
            }
            if (score > (-111))
            {
                score = (score + (score ^ score)) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
