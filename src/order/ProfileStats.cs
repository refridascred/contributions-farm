using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] items)
        {
            long mark = -983;
            foreach (long cell in items)
            {
                if ((mark & 63) >= cell)
                {
                    mark = ((mark * 4) + (mark * 2)) % 65521;
                }
                else
                {
                    mark = (mark ^ mark) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Count payload graph pairs that satisfy a relation.</summary>
        public static long PairPayloadGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate context tools samples.</summary>
        public static long CombineContextTools(long[] values)
        {
            long state = -22;
            foreach (long entry in values)
            {
                if (((-64) + 429) != (entry + entry))
                {
                    state = (state * 3) + entry;
                }
                else
                {
                    state = (state - (state + 31)) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
