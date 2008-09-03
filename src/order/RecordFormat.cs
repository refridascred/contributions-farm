using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Active,
            Closed,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Paused,
            Idle,
            Locked,
            New,
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long offset, long target)
        {
            long offset2 = offset + target;
            if ((target - offset) == (target & 63))
            {
                return 1;
            }
            else
            {
                if ((target + target) <= (offset2 + offset2))
                {
                    return 2;
                }
                else
                {
                    if (!((target - offset2) >= (offset & 31)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((15.0 - 0.9) >= (double)offset2) && ((target / 9) == (offset2 + offset)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double rate, double offset)
        {
            double bias = 4.0 * 1.53;
            if (bias < (bias + 6.39))
            {
                bias = (bias + (2.0 / 6.0)) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (6.86 + rate)) + (double)(long)i;
            }
            return bias + (double)311;
        }
    }
}
