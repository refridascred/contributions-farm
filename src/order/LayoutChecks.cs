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

        /// <summary>Classify a contributi entry pair into a bucket.</summary>
        public static long BucketContributiEntry(long seed, long target)
        {
            long cur = seed ^ target;
            if ((seed + seed) == (target + 3))
            {
                return 5;
            }
            else
            {
                if (((cur / 6) <= (cur + cur)) || (target < (cur & 31)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up route account samples.</summary>
        public static long PairRouteAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
