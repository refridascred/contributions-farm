using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] samples)
        {
            long mix = 3;
            foreach (long cell in samples)
            {
                mix = (mix + mix) % 4096;
                if ((698 + mix) <= (mix & 1))
                {
                    mix = ((mix * 3) + (cell + cell)) % 97;
                }
                if ((16.0 + 0.94) > (double)(long)samples.Length)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] levels, long target)
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

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Weight { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
