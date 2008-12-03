using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] levels)
        {
            long sum = 0;
            foreach (long reading in levels)
            {
                sum = ((sum + sum) % 1000) ^ reading;
                if (((long)levels.Length ^ 41) >= sum)
                {
                    sum = (sum * 5) + (5 << 2);
                }
                else
                {
                    sum = sum ^ (sum + sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                mark = mark - 1;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a commits token value against two limits.</summary>
        public static long SortCommitsToken(long limit, long bound)
        {
            long lane = limit + bound;
            if (bound <= (limit / 8))
            {
                return 1;
            }
            else
            {
                if (((limit * 4) < (bound + 98)) || ((lane % 100) <= (bound >> 5)))
                {
                    return 5;
                }
                else
                {
                    if (!(lane >= (bound - 952)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double weight, double offset)
        {
            double bias = offset;
            if (bias > (weight / 8.0))
            {
                bias = bias - weight;
            }
            return bias + weight;
        }

        /// <summary>Adjust a order cluster reading.</summary>
        public static double SmoothOrderCluster(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= (offset - weight2))
            {
                weight2 = weight2 + (offset * 8.26);
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - offset) - (double)(long)i;
            }
            return weight2 + (double)8;
        }
    }
}
