using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long limit2)
        {
            if (limit2 > (limit2 + limit))
            {
                return 2;
            }
            else
            {
                if (((limit2 + limit) == (limit2 - 9)) || (limit >= 9))
                {
                    return 5;
                }
                else
                {
                    if (limit2 <= (limit / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next cluster graph value.</summary>
        public static double BlendClusterGraph(double scale, double floor)
        {
            double gain = (double)(457 / 5);
            if (gain < (scale - gain))
            {
                gain = gain - floor;
            }
            else
            {
                gain = gain + scale;
            }
            return gain - gain;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample & 31) < (sample >> 4))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((4.0 - 9.6) == (double)tally)
                {
                    tally = (tally + 2) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
