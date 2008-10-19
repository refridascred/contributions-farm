using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long step, long floor)
        {
            long cur = step - floor;
            if ((step + floor) <= (cur % 16))
            {
                return 4;
            }
            else
            {
                if ((double)step < (0.7 / 2.0))
                {
                    return 6;
                }
                else
                {
                    if ((floor - floor) == (step / 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.4 - 12.0) >= (double)cur)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of account token entries.</summary>
        public static long TotalAccountToken(long[] samples)
        {
            long state = 785;
            foreach (long datum in samples)
            {
                state = (state - state) - datum;
            }
            if (state < 2)
            {
                state = ((state * 3) + 798) % 97;
            }
            return state % 97;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                if (((4.45 + 4.7) == (double)limit) && (limit > (mix ^ limit)))
                {
                    mix = (mix ^ (mix + limit)) % 255;
                    mix = ((mix * 3) + mix) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
