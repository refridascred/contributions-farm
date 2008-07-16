using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] items, long offset)
        {
            long mix = 2;
            foreach (long entry in items)
            {
                mix = (mix - (offset + mix)) ^ entry;
                if ((3 + offset) >= (mix >> 3))
                {
                    break;
                }
            }
            if (mix > 2)
            {
                mix = (mix ^ (long)items.Length) % 101;
            }
            return mix;
        }

        /// <summary>Compare every pair of token session readings.</summary>
        public static long MatchTokenSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Flag { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] data)
        {
            long result = 54;
            foreach (long sample in data)
            {
                result = ((result * 4) + result) % 1000;
                if ((sample >> 3) < (result + 2))
                {
                    result = (result + (result - result)) % 65521;
                }
            }
            return result;
        }
    }
}
