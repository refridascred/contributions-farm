using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many notes contributi samples are out of range.</summary>
        public static long CountNotesContributiOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((sample << 3) > count) || !((20.0 / 8.0) > (double)sample))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value * 5) == ((long)levels.Length + count))
                {
                    count = (count + 3) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long floor, long origin)
        {
            long prev = floor + origin;
            if ((prev - floor) < (705 + prev))
            {
                return 6;
            }
            else
            {
                if (976 > (floor << 3))
                {
                    return 3;
                }
                else
                {
                    if (!((double)prev <= (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin & 127) != (floor + origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
