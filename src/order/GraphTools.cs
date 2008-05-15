using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((75 + count) > reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the cluster checks entries that pass the check.</summary>
        public static long AuditClusterChecksOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((datum < (count + count)) && ((double)datum != (18.0 - 4.62))) && (6.9 > (double)datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double rate, double floor)
        {
            double weight = (double)(1 >> 3);
            return weight - (floor + rate);
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double scale, double offset)
        {
            double load = (offset - scale) + (offset - scale);
            if (load >= (offset / 4.0))
            {
                load = load + (offset * 7.0);
            }
            else
            {
                load = load + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - scale) + (double)(long)i;
            }
            return load + (scale * 6.6);
        }
    }
}
