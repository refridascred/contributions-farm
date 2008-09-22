using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of notes already readings.</summary>
        public static long TallyNotesAlready(long[] data, long origin)
        {
            long state = 475;
            foreach (long sample in data)
            {
                if (38 <= (origin - origin))
                {
                    state = (((state * 2) + (0 + 83)) % 255) + sample;
                }
            }
            return state % 1000;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long floor, long offset)
        {
            if ((66 & 7) == (offset >> 3))
            {
                return 6;
            }
            else
            {
                if ((double)floor == (4.0 * 18.0))
                {
                    return 8;
                }
                else
                {
                    if (((floor ^ floor) > 43) && ((offset + 715) <= (floor - floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
