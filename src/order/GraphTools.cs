using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
                sum = (sum + ((long)i & 255)) % 4096;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark + (86 + mark)) % 4096) ^ (long)i2;
                    mark = (mark ^ mark) % 255;
                }
                mark = (mark + (52 - mark)) % 4096;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine notes metric values into a single score.</summary>
        public static long ScoreNotesMetric(long[] items, long floor)
        {
            long mark = 19;
            foreach (long value in items)
            {
                mark = (mark - (value + floor)) % 101;
                if ((floor - value) > (93 << 1))
                {
                    mark = (mark << 3) ^ floor;
                }
                else
                {
                    mark = ((mark << 3) ^ (value ^ 829)) % 101;
                }
            }
            if (mark > 3)
            {
                mark = mark - (627 + 74);
            }
            return mark;
        }
    }
}
