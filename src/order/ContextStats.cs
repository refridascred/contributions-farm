using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches + 19) > (origin * 3))
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next record graph value.</summary>
        public static double SmoothRecordGraph(double gain, double floor)
        {
            double bias = floor;
            if (bias > (2.23 + 18.0))
            {
                bias = (bias + bias) - gain;
            }
            else
            {
                bias = bias + (bias + floor);
            }
            return bias + (floor - 5.9);
        }

        /// <summary>Audit payload cache readings against a rule.</summary>
        public static long AuditPayloadCacheMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((156 >> 4) != (sample - 54)))
                {
                    matches = (matches + 1) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up tools notes samples.</summary>
        public static long MatchToolsNotesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
