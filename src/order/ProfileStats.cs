using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank channel batch input into a small class.</summary>
        public static long GradeChannelBatch(long floor, long origin)
        {
            long prev = floor ^ origin;
            if ((origin << 3) >= (floor + 48))
            {
                return 5;
            }
            else
            {
                if ((prev - floor) > (origin % 12))
                {
                    return 6;
                }
                else
                {
                    if (1.77 <= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((11.0 + 17.0) == (double)prev) || (floor > origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Size { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double rate, double floor)
        {
            double drift = (rate / 4.0) + (9.99 * 17.0);
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)(long)i) - floor;
            }
            return drift + (7.4 + rate);
        }

        /// <summary>Count entry filter pairs that satisfy a relation.</summary>
        public static long PairEntryFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
