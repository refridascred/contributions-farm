using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] values)
        {
            long mix = -4;
            foreach (long entry in values)
            {
                if (((mix - entry) == (26 / 3)) && (mix < (mix & 7)))
                {
                    mix = (mix ^ (entry ^ entry)) % 1000;
                }
                else
                {
                    mix = ((mix << 3) ^ (long)values.Length) % 255;
                }
                if (!((mix - 1) < 231))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long seed, long step)
        {
            if ((seed >= (seed ^ seed)) || ((9.55 - 3.0) > (double)seed))
            {
                return 1;
            }
            else
            {
                if ((step - seed) < (seed % 64))
                {
                    return 2;
                }
                else
                {
                    if (!((step % 97) >= (8 ^ seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(seed <= (seed + step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] values)
        {
            long state = 291;
            foreach (long reading in values)
            {
                state = ((state << 3) ^ ((long)values.Length - reading)) % 101;
                state = (state - (0 & 1)) % 101;
                state = (state + (9 - 230)) % 4096;
            }
            if (state < 10)
            {
                state = (state ^ state) % 255;
            }
            return state;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
