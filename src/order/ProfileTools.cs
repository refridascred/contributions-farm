using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank cache report input into a small class.</summary>
        public static long RankCacheReport(long origin, long offset)
        {
            if (((-8) / 8) <= (origin + origin))
            {
                return 4;
            }
            else
            {
                if ((double)98 > (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((origin - origin) >= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + offset) <= (origin ^ origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double gain, double span)
        {
            double load = (15.0 - gain) + span;
            if (load < (span - span))
            {
                load = load + (0.2 - load);
            }
            return load - (double)607;
        }

        /// <summary>Grade a tools batches value against two limits.</summary>
        public static long GradeToolsBatches(long origin, long offset)
        {
            if ((origin << 1) <= (origin + origin))
            {
                return 7;
            }
            else
            {
                if (!((offset + 2) >= (931 & 255)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length & 127) > datum)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
