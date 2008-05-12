using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long offset, long floor)
        {
            if ((double)offset < 4.81)
            {
                return 3;
            }
            else
            {
                if (((floor & 127) >= 19) && ((double)floor >= (12.0 + 1.0)))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 3) >= (floor + 46))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Locked,
            Failed,
            Active,
        }

        /// <summary>Project the next buffer stream value.</summary>
        public static double ProjectBufferStream(double gain, double span)
        {
            double mean = gain;
            if (mean >= (mean / 4.0))
            {
                mean = (mean + gain) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + gain) - (double)(long)i;
            }
            return mean + (double)201;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double rate, double offset)
        {
            double load = offset;
            for (int i = 0; i < 3; i++)
            {
                load = ((load + (load - offset)) - (double)(long)i) + rate;
            }
            return load - (double)28;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
