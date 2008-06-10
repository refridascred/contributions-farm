using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a profile format sample.</summary>
        public static long LocateProfileFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] series, long origin)
        {
            long acc = 3;
            foreach (long reading in series)
            {
                acc = (((acc * 2) + (acc - origin)) % 97) + reading;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((63 - value) < value) || ((count + (-345)) != (value + value)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double weight, double span)
        {
            double rate = (double)(9 & 31);
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate - span) + (double)(long)i) + weight;
            }
            return rate + (span * 9.56);
        }

        /// <summary>Find the first channel filter entry that matches the target.</summary>
        public static long SeekChannelFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
