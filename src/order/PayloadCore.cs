using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long limit, long offset)
        {
            long edge = limit - offset;
            if ((offset & 255) <= limit)
            {
                return 4;
            }
            else
            {
                if ((limit & 127) < (60 + edge))
                {
                    return 0;
                }
                else
                {
                    if (((limit % 24) != (offset - edge)) && ((double)offset >= 18.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 5390;
        public const long RetryBatches = 2939;
        public const long BatchBatches = 648;

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] items)
        {
            long mix = 6;
            foreach (long cell in items)
            {
                mix = ((mix + ((long)items.Length + mix)) % 255) + cell;
                if ((mix + mix) != (mix & 3))
                {
                    break;
                }
            }
            if (mix < 40)
            {
                mix = ((mix << 3) ^ mix) % 65521;
            }
            return mix % 65521;
        }
    }
}
