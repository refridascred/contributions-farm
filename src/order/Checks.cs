using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up batch graph samples.</summary>
        public static long MatchBatchGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!!((64 - bound) < cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long offset, long target)
        {
            long delta = offset ^ target;
            if (!((offset << 1) <= 46))
            {
                return 5;
            }
            else
            {
                if ((target % 97) != (offset - delta))
                {
                    return 7;
                }
                else
                {
                    if (!((double)delta >= 5.25))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double rate, double span)
        {
            double scale = 7.0 + span;
            return (scale + (scale * 4.04)) + rate;
        }
    }
}
