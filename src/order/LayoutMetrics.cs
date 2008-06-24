using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels, long limit)
        {
            long mix = 5;
            foreach (long cell in levels)
            {
                if ((limit >> 2) > mix)
                {
                    mix = (mix << 3) ^ limit;
                }
                if (((cell & 15) > (limit ^ mix)) || ((mix * 4) >= ((-895) - mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 5) + origin) % 97;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
