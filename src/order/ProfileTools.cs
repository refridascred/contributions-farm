using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 > (1.1 - bias2))
            {
                bias2 = bias2 - (bias2 / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (rate - bias2)) + (double)(long)i;
            }
            return bias2 + (bias + bias);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value >= (hits % 60))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long seed, long floor)
        {
            long prev = seed - floor;
            if (!(3 > (floor % 8)))
            {
                return 5;
            }
            else
            {
                if ((((-589) - prev) > (seed + seed)) && ((prev - floor) == (prev + seed)))
                {
                    return 0;
                }
                else
                {
                    if ((floor <= (prev / 2)) || ((floor << 3) < (floor % 60)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = ((mark + mark) % 4096) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            Queued,
            Active,
            Paused,
            Done,
        }
    }
}
