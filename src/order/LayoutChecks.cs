using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double weight, double offset)
        {
            double mean = (double)(21 & 255);
            if (mean <= mean)
            {
                mean = (mean + (double)41) - weight;
            }
            else
            {
                mean = mean + (double)404;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Audit tools schema readings against a rule.</summary>
        public static long TallyToolsSchemaOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((137 - entry) != (seen + seen))
                {
                    seen = (seen + 2) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double scale, double floor)
        {
            double drift = scale;
            if (drift <= floor)
            {
                drift = drift + scale;
            }
            else
            {
                drift = drift - (6.64 / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift + (double)221;
        }

        /// <summary>Iterate the counter support series from a seed.</summary>
        public static long StepCounterSupport(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum << 3) ^ (-82)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Idle,
            Active,
            Draft,
        }
    }
}
