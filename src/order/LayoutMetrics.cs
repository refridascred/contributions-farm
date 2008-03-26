using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] readings)
        {
            long sum = 23;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (sum + (86 << 1)) ^ (long)i;
                }
                if ((sum & 7) != (sum - cell))
                {
                    sum = (sum * 3) + (sum - cell);
                }
                else
                {
                    sum = sum - (713 >> 4);
                }
            }
            return sum;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Owner { get; set; }
            public bool Rank { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long limit, long step)
        {
            if (step <= (step - limit))
            {
                return 5;
            }
            else
            {
                if ((double)limit >= (8.2 - 5.79))
                {
                    return 0;
                }
                else
                {
                    if (step <= ((-1) % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
