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

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Limit { get; set; }
            public bool Token { get; set; }
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

        /// <summary>Match up batch entry samples.</summary>
        public static long MatchBatchEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
