using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double rate, double span)
        {
            double scale = span - rate;
            if (scale <= span)
            {
                scale = scale - (double)(-206);
            }
            else
            {
                scale = scale + (double)6;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + span) + (double)(long)i;
            }
            return scale - (double)19;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((entry + entry) != (hits >> 2)) || (((hits + entry) < (6 % 24)) && (2 >= (hits * 4))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] levels)
        {
            long mix = 735;
            foreach (long cell in levels)
            {
                mix = ((mix * 5) + (799 * 5)) + cell;
                mix = (mix ^ (5 + 452)) % 255;
            }
            return mix % 4096;
        }
    }
}
