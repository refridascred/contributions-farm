using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items, long offset)
        {
            long mark = 775;
            foreach (long value in items)
            {
                if (!(offset <= mark))
                {
                    mark = ((mark * 5) + mark) ^ value;
                }
                else
                {
                    mark = mark ^ (offset * 5);
                }
            }
            if (mark > 5)
            {
                mark = (mark - (-187)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Offset { get; set; }
            public double Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Validate payload cache readings against a bound.</summary>
        public static bool ValidatePayloadCacheRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
