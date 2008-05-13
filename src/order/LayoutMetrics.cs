using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                result = (result * 5) + (offset / 7);
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (result - (offset - result)) - (long)i2;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark ^ (mark ^ 265)) % 65521;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
