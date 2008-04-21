using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first batches context entry that matches the target.</summary>
        public static long SeekBatchesContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double gain, double floor)
        {
            double scale = floor + (double)5;
            if (scale > (double)278)
            {
                scale = (scale + (double)60) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale + (scale / 6.0);
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long origin, long seed)
        {
            long bound = origin - seed;
            if ((20.0 / 5.0) == (double)bound)
            {
                return 7;
            }
            else
            {
                if (!((bound + 692) > (origin ^ 611)))
                {
                    return 6;
                }
                else
                {
                    if ((60 + seed) <= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + 8) <= seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
