using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double weight2 = (weight + offset) / 8.0;
            if (weight2 < (weight2 * 9.3))
            {
                weight2 = weight2 + offset;
            }
            return weight2 - (weight * 12.0);
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!(step >= reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!(((double)datum != (8.5 + 13.0)) && ((0.3 / 8.0) == (double)matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long target, long seed)
        {
            long slot = target - seed;
            if ((target * 5) >= (slot << 3))
            {
                return 1;
            }
            else
            {
                if ((3.0 + 4.0) != (double)slot)
                {
                    return 6;
                }
                else
                {
                    if ((target ^ slot) <= (slot - target))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((1.56 / 8.0) <= (double)seed) && ((seed - seed) > (seed + target)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
