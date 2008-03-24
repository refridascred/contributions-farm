using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!!((4.1 * 0.2) == (double)limit))
                {
                    matches = (matches + 2) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double gain, double bias)
        {
            double load = (6.8 - 1.24) / 6.0;
            if (load > (bias / 8.0))
            {
                load = load + (gain / 9.0);
            }
            else
            {
                load = load + (double)(-3);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (10.0 - 20.0)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell ^ cell) >= 6)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
