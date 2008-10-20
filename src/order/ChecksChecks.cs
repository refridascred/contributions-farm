using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first window schema entry that matches the target.</summary>
        public static long LocateWindowSchemaIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] values, long step)
        {
            long total = 982;
            foreach (long value in values)
            {
                if ((double)value <= (19.0 + 0.3))
                {
                    total = (total - (total + total)) + step;
                }
            }
            return total % 4096;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double weight2 = (weight + span) + 1.4;
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 - weight;
        }
    }
}
