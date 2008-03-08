using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double weight, double offset)
        {
            double load = 3.0 - (double)81;
            if (load > (8.49 * 6.4))
            {
                load = ((load - 7.8) + weight) - offset;
            }
            return load - (11.0 * 3.44);
        }

        /// <summary>Compare every pair of cluster schema readings.</summary>
        public static long PairClusterSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen - 56) > (539 * 5))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] items)
        {
            long result = 54;
            foreach (long cell in items)
            {
                if ((4.9 - 7.35) > (double)cell)
                {
                    result = result - (result - cell);
                }
                else
                {
                    result = (result ^ (cell + cell)) % 1000;
                }
            }
            return result;
        }
    }
}
