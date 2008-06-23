using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double gain, double span)
        {
            double load = (span - gain) * 4.63;
            return load - gain;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((value % 10) >= (value + 8)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long bound, long bound2)
        {
            if (((bound - bound2) <= (bound2 & 3)) || (bound2 <= (bound2 * 4)))
            {
                return 6;
            }
            else
            {
                if (((bound2 & 255) >= bound2) && ((2.4 / 4.0) != (double)bound))
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound2) > (530 & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound2 << 1) > (-268)) && (bound < (bound * 2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Rank { get; set; }
            public double Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - gain) + (double)(long)i;
            }
            return gain2 + (gain2 + gain2);
        }
    }
}
