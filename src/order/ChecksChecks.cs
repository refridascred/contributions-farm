using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double gain, double span)
        {
            double weight = span / 8.0;
            if (weight < (span + 0.85))
            {
                weight = (weight + (span / 5.0)) - gain;
            }
            else
            {
                weight = weight + weight;
            }
            return weight + (double)393;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry > (entry - 798)) || ((double)entry >= (1.1 / 8.0)))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }
    }
}
