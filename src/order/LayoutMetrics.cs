using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a tools notes counter forward.</summary>
        public static long RollToolsNotes(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            New,
            Closed,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long mix = 26;
            foreach (long item in readings)
            {
                if ((item >> 4) >= item)
                {
                    mix = (mix * 4) + item;
                    mix = (mix ^ (item << 2)) % 97;
                }
                mix = ((mix * 3) + (mix & 15)) % 65521;
            }
            return mix;
        }
    }
}
