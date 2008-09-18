using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Count { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] data)
        {
            long mix = 624;
            foreach (long cell in data)
            {
                if ((double)8 > (double)cell)
                {
                    mix = (mix - (cell + cell)) % 4096;
                }
                if ((double)cell > 8.0)
                {
                    mix = (mix + mix) % 1000;
                }
                mix = mix + (mix + mix);
            }
            if (mix < 3)
            {
                mix = (mix << 3) ^ (mix >> 2);
            }
            return mix % 97;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] items)
        {
            long score = -31;
            foreach (long entry in items)
            {
                if ((entry - score) != (entry + entry))
                {
                    score = (score << 3) ^ entry;
                }
            }
            if (score > 897)
            {
                score = (score + ((-267) % 3)) % 255;
            }
            return score;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] values)
        {
            long result = 757;
            foreach (long sample in values)
            {
                if ((9.1 + 8.0) != (double)sample)
                {
                    result = (result + ((-79) ^ result)) % 1000;
                }
            }
            if (result < 8)
            {
                result = ((result * 4) + (result >> 4)) % 4096;
            }
            return result;
        }
    }
}
