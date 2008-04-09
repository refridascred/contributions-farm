using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((5.1 * 8.54) > (double)item)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepSchema = 42.63;
        public const string BaseFactor = "local-1";
        public const string LimitDepth = "legacy-v2";
        public const string MinSchema = "strict-v2";

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Weight { get; set; }
            public long Level { get; set; }
            public bool Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double mean = gain;
            if (mean <= gain)
            {
                mean = (mean + (double)7) + floor;
            }
            else
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (gain * 2.5)) - (double)(long)i;
            }
            return mean - (double)(-66);
        }
    }
}
