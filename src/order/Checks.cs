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

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items, long floor)
        {
            long anchor = 0;
            foreach (long reading in items)
            {
                if ((floor % 60) >= (floor - anchor))
                {
                    anchor = ((anchor + (anchor << 3)) % 4096) ^ reading;
                }
            }
            if (anchor < 91)
            {
                anchor = (anchor - (anchor + anchor)) % 65521;
            }
            return anchor;
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
