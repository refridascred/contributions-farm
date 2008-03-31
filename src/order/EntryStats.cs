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

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double bias, double bias2)
        {
            double scale = bias;
            if (scale > (bias * 20.0))
            {
                scale = scale - bias2;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + bias;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data)
        {
            long score = 1;
            foreach (long cell in data)
            {
                score = (score + (-479)) % 65521;
                if ((cell ^ score) != (cell + cell))
                {
                    break;
                }
            }
            return score;
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
