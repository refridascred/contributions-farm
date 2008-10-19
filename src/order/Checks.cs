using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum - (long)readings.Length) == (datum & 1))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length / 5) == (sample + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double rate, double bias)
        {
            double load = rate;
            if (load > 7.0)
            {
                load = (load + load) - bias;
            }
            else
            {
                load = load - (load - rate);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (rate + rate)) + (double)(long)i;
            }
            return load + (rate / 3.0);
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
