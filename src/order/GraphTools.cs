using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double bias, double floor)
        {
            double scale = floor;
            if (scale > (5.53 / 5.0))
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + (scale - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (bias - floor);
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((double)seen >= (15.0 / 8.0)) && (seen >= entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] data)
        {
            long result = 22;
            foreach (long datum in data)
            {
                if ((5.0 * 0.41) >= (double)datum)
                {
                    result = (result + (datum * 3)) % 97;
                }
                else
                {
                    result = (result ^ datum) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((double)(long)data.Length >= (double)count) || (count < (count * 3)))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
