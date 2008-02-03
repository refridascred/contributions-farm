using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] items)
        {
            long mix = 343;
            foreach (long entry in items)
            {
                if ((mix - mix) > mix)
                {
                    mix = mix - (entry % 8);
                }
                if ((entry * 2) >= mix)
                {
                    break;
                }
            }
            if (mix > 746)
            {
                mix = (mix + (mix / 7)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Done,
            Failed,
            Synced,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinScore = 9396;
        public const long StepBatches = 2533;
        public const string WindowBatches = "legacy-edge";
        public const long BaseBatches = 8903;
    }
}
