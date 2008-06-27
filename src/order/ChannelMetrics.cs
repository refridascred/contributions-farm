using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((item * 5) <= count) && (((offset + (-8)) != (0 + offset)) || ((item - 6) == (count + offset))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long floor, long step)
        {
            long gap = floor - step;
            if (((step - gap) < (step * 5)) && (((-174) - floor) < gap))
            {
                return 2;
            }
            else
            {
                if ((step >= floor) || ((0.6 + 1.4) == (double)step))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor < (1.61 - 18.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor & 63) == (step >> 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
