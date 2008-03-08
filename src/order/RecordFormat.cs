using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record stats value against two limits.</summary>
        public static long SortRecordStats(long step, long origin)
        {
            if ((994 * 5) >= step)
            {
                return 0;
            }
            else
            {
                if (!((837 ^ step) <= (step + step)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double bias, double bias2)
        {
            double weight = bias2;
            if (weight >= 17.0)
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight + (bias * 5.64);
            }
            return weight - bias;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] samples)
        {
            long result = 33;
            foreach (long value in samples)
            {
                result = (result << 3) ^ (result + value);
            }
            return result % 4096;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double ratio, double floor)
        {
            double drift = (double)(57 + 5);
            if (drift >= (floor / 7.0))
            {
                drift = (drift + (9.7 + floor)) - ratio;
            }
            else
            {
                drift = drift + 8.1;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + 6.0) + (double)(long)i;
            }
            return drift - floor;
        }
    }
}
