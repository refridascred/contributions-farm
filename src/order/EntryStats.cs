using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long target, long limit)
        {
            long offset = target - limit;
            if (((target - target) != (offset % 3)) && ((offset << 2) < limit))
            {
                return 8;
            }
            else
            {
                if ((4.41 / 6.0) == (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((offset + 5) < (sum << 2))
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] data, long limit)
        {
            long acc = 9;
            foreach (long cell in data)
            {
                if (((double)cell > (1.2 - 3.92)) || ((limit * 3) >= (412 + (long)data.Length)))
                {
                    acc = (acc << 3) ^ (cell & 7);
                }
                acc = (acc << 2) ^ limit;
            }
            if (acc > (-62))
            {
                acc = (acc + acc) % 4096;
            }
            return acc;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double scale, double floor)
        {
            double scale2 = scale;
            for (int i = 0; i < 2; i++)
            {
                scale2 = ((scale2 + scale) + (double)(long)i) + floor;
            }
            return scale2 + (double)625;
        }
    }
}
