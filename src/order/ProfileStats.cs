using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long target, long offset)
        {
            long lane = target - offset;
            if (((double)offset == (double)lane) && ((lane + 314) < (lane >> 4)))
            {
                return 6;
            }
            else
            {
                if ((lane + target) >= (offset + target))
                {
                    return 7;
                }
                else
                {
                    if ((0.1 + 12.0) <= (double)lane)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)target > (4.0 * 5.3)) || ((lane / 6) > (lane + offset)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell + cell) >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
