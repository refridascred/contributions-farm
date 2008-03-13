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

        /// <summary>Combine session batches values into a single score.</summary>
        public static long FoldSessionBatches(long[] levels)
        {
            long state = 73;
            foreach (long value in levels)
            {
                state = (state - state) ^ value;
            }
            if (state < 69)
            {
                state = (state - (state & 7)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Queued,
            Synced,
            Locked,
            Idle,
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
