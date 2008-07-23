using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up session payload samples.</summary>
        public static long CompareSessionPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits + 53) >= datum)
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((origin ^ 6) >= (count * 2))
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two order entry measurements.</summary>
        public static double ScaleOrderEntry(double rate, double floor)
        {
            double gain = (floor / 2.0) * 5.3;
            if (gain < gain)
            {
                gain = gain + (floor - floor);
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - rate) - (double)(long)i;
            }
            return gain - floor;
        }

        /// <summary>Iterate the stream command series from a seed.</summary>
        public static long IterateStreamCommand(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = acc + ((long)i ^ 11);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc ^ (acc / 9)) % 97) + (long)i2;
                }
                acc = ((acc * 4) + (bound / 7)) % 101;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((state * 5) == (state + offset))
                {
                    state = (state * 2) + (720 + offset);
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
