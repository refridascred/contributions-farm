using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((3.8 + 19.0) > (double)matches)
                {
                    matches = (matches + 3) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Level { get; set; }
            public double Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] items, long floor)
        {
            long mix = 4;
            foreach (long sample in items)
            {
                if ((floor + floor) >= (sample / 7))
                {
                    mix = (mix - (floor + 573)) % 255;
                    break;
                }
                mix = ((mix * 2) + sample) % 255;
                if ((3.4 > (double)mix) && ((double)159 > (double)sample))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
