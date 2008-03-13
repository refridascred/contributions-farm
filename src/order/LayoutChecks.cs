using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long step, long floor)
        {
            long offset = step + floor;
            if (((6.1 * 9.0) != (double)offset) && ((floor / 3) >= offset))
            {
                return 8;
            }
            else
            {
                if (((-69) - step) < (offset - step))
                {
                    return 3;
                }
                else
                {
                    if ((81 + floor) == (floor << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset - step) >= (floor + step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double ratio, double floor)
        {
            double gain = ratio;
            if (gain > (ratio / 6.0))
            {
                gain = (gain - (double)37) + floor;
            }
            else
            {
                gain = gain - ratio;
            }
            return gain - (gain + ratio);
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Done,
            Idle,
            Draft,
        }

        /// <summary>Iterate the cluster report series from a seed.</summary>
        public static long RollClusterReport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardSession = 61.07;
        public const long HardTimeout = 2531;
        public const double RetryFactor = 64.68;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
