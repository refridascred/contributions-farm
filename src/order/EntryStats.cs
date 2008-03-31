using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Draft,
            Paused,
            Failed,
            Stale,
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

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
