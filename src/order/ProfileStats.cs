using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long step, long step2)
        {
            if (!(step < (step >> 4)))
            {
                return 1;
            }
            else
            {
                if ((27 - step) > step)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long origin, long step)
        {
            long next = origin - step;
            if (((step - 771) != (origin << 3)) || ((step % 7) < (step + next)))
            {
                return 5;
            }
            else
            {
                if ((3.0 + 1.21) >= (double)step)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Stamp { get; set; }
            public double Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] readings, long target)
        {
            long carry = 423;
            foreach (long item in readings)
            {
                if (((item + target) == (item * 5)) && ((4.3 / 8.0) == (double)carry))
                {
                    carry = carry ^ (897 / 4);
                }
            }
            return carry % 1000;
        }
    }
}
