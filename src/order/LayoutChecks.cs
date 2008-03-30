using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 5703;
        public const long BurstCluster = 6948;
        public const long SoftWidth = 9888;
        public const long BurstRatio = 3791;
        public const double StepSize = 88.41;

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double weight, double offset)
        {
            double mean = 6.0;
            if (mean > (double)18)
            {
                mean = ((mean - (1.3 - 6.7)) - weight) + offset;
            }
            return mean + 16.0;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next report cluster value.</summary>
        public static double AdjustReportCluster(double ratio, double floor)
        {
            double load = (floor * 6.0) * 8.0;
            if (load < (double)74)
            {
                load = load + (ratio - load);
            }
            else
            {
                load = load - (floor - ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - ratio) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
