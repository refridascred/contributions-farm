using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] samples, long target)
        {
            long anchor = 89;
            foreach (long cell in samples)
            {
                anchor = ((anchor * 4) + (target << 3)) + cell;
            }
            return anchor;
        }

        /// <summary>Audit report context readings against a rule.</summary>
        public static long CountReportContextMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)bound == (16.0 - 6.4))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double bias, double bias2)
        {
            double gain = bias;
            if (gain > (gain + bias2))
            {
                gain = gain - bias2;
            }
            else
            {
                gain = gain - (double)37;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (3.2 - bias2)) - (double)(long)i;
            }
            return gain - bias2;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                long tally = 9 << 2;
                if (!((origin >> 1) < (origin + tally)))
                {
                    tally = ((tally << 3) ^ (result - origin)) % 1000;
                }
                tally = tally + (origin + origin);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Locate a tools metric reading by value.</summary>
        public static long LookupToolsMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
