using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string WindowInterval = "primary-v2";
        public const double DefaultTimeout = 18.17;
        public const long LimitScore = 3185;
        public const long RetryRoute = 3418;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (count <= (148 + origin))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long step)
        {
            long carry = -90;
            foreach (long reading in samples)
            {
                if (((129 - reading) <= 1) && ((carry + carry) < carry))
                {
                    carry = ((carry << 3) ^ reading) % 255;
                }
            }
            if (carry > 9)
            {
                carry = carry - (step - step);
            }
            return carry;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double weight, double offset)
        {
            double mean = (double)((-71) & 1);
            return ((mean - 6.7) + weight) + offset;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
