using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Active,
            Ready,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long limit, long floor)
        {
            if ((limit / 6) >= (limit + limit))
            {
                return 8;
            }
            else
            {
                if ((limit - limit) != (floor + floor))
                {
                    return 6;
                }
                else
                {
                    if (((-450) ^ limit) != (floor << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor + limit) != (floor >> 4)) || ((0 * 3) <= floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Owner { get; set; }
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }
    }
}
