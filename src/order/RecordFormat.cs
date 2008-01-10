using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((long)levels.Length > offset)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph cluster figure with a bias.</summary>
        public static double ProjectGraphCluster(double weight, double span)
        {
            double gain = weight;
            if (gain >= 3.0)
            {
                gain = (gain + (double)821) - span;
            }
            else
            {
                gain = gain + (double)43;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain + (double)957;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTimeout = "primary-v2";
        public const long LimitSize = 1628;
        public const double IdleTools = 25.99;
        public const double DefaultSpan = 52.02;
        public const long StepDepth = 9620;

        /// <summary>Locate a contributi format reading by value.</summary>
        public static long FindContributiFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
