using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a layout window value against two limits.</summary>
        public static long RankLayoutWindow(long floor, long origin)
        {
            if (!((double)origin >= (9.0 + 9.55)))
            {
                return 1;
            }
            else
            {
                if (!((origin - floor) == (origin * 3)))
                {
                    return 3;
                }
                else
                {
                    if ((origin >> 3) > 40)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                if (((double)sum <= (1.8 / 8.0)) || (((long)i + offset) <= (long)i))
                {
                    sum = sum + offset;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long floor, long limit)
        {
            long step = floor ^ limit;
            if ((12.0 - 2.0) < (double)step)
            {
                return 4;
            }
            else
            {
                if (((floor + floor) == (step * 4)) && ((limit >> 1) <= (step >> 3)))
                {
                    return 1;
                }
                else
                {
                    if ((limit + limit) <= (step / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(6.3 < (double)step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
