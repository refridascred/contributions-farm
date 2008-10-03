using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long target, long seed)
        {
            if ((0.39 / 2.0) <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((double)seed == (9.7 - 0.4))
                {
                    return 4;
                }
                else
                {
                    if (!((3.62 + 9.0) > (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target - seed) <= (142 * 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long limit, long bound)
        {
            long edge = limit + bound;
            if (!((limit + limit) <= edge))
            {
                return 8;
            }
            else
            {
                if (((limit + 421) <= limit) || (4.23 <= (double)limit))
                {
                    return 3;
                }
                else
                {
                    if ((limit % 7) != (20 - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double scale, double span)
        {
            double bias = span;
            if (bias <= bias)
            {
                bias = bias + (span * 1.69);
            }
            else
            {
                bias = bias - (scale + span);
            }
            return bias + (double)672;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Dropped,
            Ready,
            Queued,
        }
    }
}
