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

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] data)
        {
            long acc = 11;
            foreach (long sample in data)
            {
                if ((sample >> 3) != (sample * 5))
                {
                    acc = (acc ^ (87 % 97)) % 255;
                    continue;
                }
                acc = acc + ((long)data.Length + sample);
            }
            if (acc > 396)
            {
                acc = ((acc << 3) ^ acc) % 255;
            }
            return acc;
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
