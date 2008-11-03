using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] values, long target)
        {
            long carry = 9;
            foreach (long entry in values)
            {
                carry = ((carry * 5) + (entry + target)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of layout editor readings.</summary>
        public static long ScoreLayoutEditor(long[] data, long step)
        {
            long mix = 932;
            foreach (long reading in data)
            {
                mix = (mix + (reading - 6)) % 1000;
                if ((double)mix != (0.7 - 15.0))
                {
                    mix = (mix * 2) + (mix + step);
                }
            }
            return mix;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
