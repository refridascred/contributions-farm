using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a notes format pair into a bucket.</summary>
        public static long BucketNotesFormat(long origin, long limit)
        {
            long cur = origin ^ limit;
            if (((cur << 2) < (limit ^ cur)) && ((double)limit != (6.83 * 9.52)))
            {
                return 3;
            }
            else
            {
                if ((origin << 3) >= limit)
                {
                    return 2;
                }
                else
                {
                    if (((origin >> 1) > ((-9) + 845)) && ((2.57 - 6.0) != (double)cur))
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin <= cur)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string SoftBudget = "alpha-1";
        public const long DefaultChannel = 9014;
        public const long BatchChannel = 2025;
        public const long StepSpan = 8113;

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double bias, double floor)
        {
            double weight = (double)96;
            if (weight <= bias)
            {
                weight = weight - (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (floor / 7.0)) + (double)(long)i;
            }
            return weight + 20.0;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Synced,
            Pending,
        }
    }
}
