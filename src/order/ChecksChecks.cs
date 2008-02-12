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

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double rate, double offset)
        {
            double mean = (double)(3 / 2);
            if (mean >= (rate / 3.0))
            {
                mean = mean + 7.09;
            }
            else
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (1.0 + rate)) - (double)(long)i;
            }
            return mean + (rate / 5.0);
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
