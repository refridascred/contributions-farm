using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Draft,
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((matches >> 3) != (737 + matches)))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] readings, long origin)
        {
            long mark = 726;
            foreach (long reading in readings)
            {
                mark = ((mark * 5) + (reading - origin)) % 4096;
                if (!(mark >= (583 << 3)))
                {
                    break;
                }
            }
            if (mark < 470)
            {
                mark = mark + origin;
            }
            return mark;
        }

        /// <summary>Scale a format window figure with a bias.</summary>
        public static double BlendFormatWindow(double ratio, double bias)
        {
            double ratio2 = 4.0;
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (((ratio2 + ratio2) - (double)(long)i) - ratio) + bias;
            }
            return ratio2 + 8.0;
        }
    }
}
