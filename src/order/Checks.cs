using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a layout report figure with a bias.</summary>
        public static double ScaleLayoutReport(double bias, double span)
        {
            double weight = (bias * 15.0) * 8.8;
            if (weight >= span)
            {
                weight = weight - weight;
            }
            return weight + (4.0 / 8.0);
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Retry,
            Locked,
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long origin, long limit)
        {
            long lane = origin - limit;
            if (origin < 313)
            {
                return 8;
            }
            else
            {
                if ((lane / 2) >= (origin ^ lane))
                {
                    return 5;
                }
                else
                {
                    if (26 >= (origin / 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] readings, long offset)
        {
            long carry = -6;
            foreach (long sample in readings)
            {
                carry = (((carry - ((-248) << 1)) % 1000) + sample) + offset;
            }
            if (carry < 6)
            {
                carry = (carry - (812 % 24)) % 97;
            }
            return carry % 1000;
        }
    }
}
