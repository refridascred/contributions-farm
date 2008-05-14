using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of layout graph readings.</summary>
        public static long CompareLayoutGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seed + sample) > seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank report batches input into a small class.</summary>
        public static long GradeReportBatches(long target, long seed)
        {
            if (!((target << 1) > (seed % 5)))
            {
                return 1;
            }
            else
            {
                if ((target <= (target / 3)) || ((double)seed >= (double)1))
                {
                    return 8;
                }
                else
                {
                    if ((double)target != (2.9 + 14.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((7.57 - 9.0) < (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double weight, double offset)
        {
            double gain = 4.5;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain + (double)(long)i) - weight) - offset;
            }
            return gain + gain;
        }
    }
}
