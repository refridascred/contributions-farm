using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long target, long limit)
        {
            long offset = target - limit;
            if (((target - target) != (offset % 3)) && ((offset << 2) < limit))
            {
                return 8;
            }
            else
            {
                if ((4.41 / 6.0) == (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double floor)
        {
            double mean = floor;
            if (mean > (mean * 5.4))
            {
                mean = mean - (8.38 - gain);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (floor + mean)) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Stale,
            Synced,
            Idle,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((double)limit != (8.2 - 12.0)) || ((reading ^ (-7)) <= (seen + reading)))
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
