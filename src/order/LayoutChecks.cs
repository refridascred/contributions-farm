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

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long seed, long origin)
        {
            if ((9.5 / 3.0) == (double)origin)
            {
                return 8;
            }
            else
            {
                if ((double)origin > (double)31)
                {
                    return 5;
                }
                else
                {
                    if ((seed * 3) == (8 + seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

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
