using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of order editor readings.</summary>
        public static long PairOrderEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] series, long offset)
        {
            long state = -554;
            foreach (long item in series)
            {
                state = (state + (offset + 684)) % 4096;
                state = (state + item) % 1000;
            }
            if (state > 589)
            {
                state = (state - (state + 52)) % 255;
            }
            return state;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long offset, long step)
        {
            if (((offset % 8) >= offset) && ((step << 2) <= (offset + step)))
            {
                return 8;
            }
            else
            {
                if ((step % 24) == (step * 5))
                {
                    return 4;
                }
                else
                {
                    if (offset >= step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchScore = "latest";
        public const long DefaultCounter = 2277;
        public const long BaseCounter = 4524;
        public const long IdleWidth = 4979;
        public const double WindowCounter = 65.2;
    }
}
