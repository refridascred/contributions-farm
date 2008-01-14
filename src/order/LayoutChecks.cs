using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultBudget = 9239;
        public const long BatchTimeout = 8322;
        public const double DefaultLevel = 26.78;
        public const string MaxDepth = "standard-1";
        public const long HardEntry = 9246;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit stream schema readings against a rule.</summary>
        public static long CountStreamSchemaHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= 2.0)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((double)seen >= (4.2 - 2.0)) && (0 > item))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double scale, double floor)
        {
            double drift = (double)(5 << 1);
            if (drift >= scale)
            {
                drift = (drift - scale) - floor;
            }
            return drift - 2.0;
        }
    }
}
