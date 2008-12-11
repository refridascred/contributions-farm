using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank payload counter input into a small class.</summary>
        public static long RankPayloadCounter(long bound, long bound2)
        {
            long lane = bound - bound2;
            if ((lane + bound) >= (bound2 - lane))
            {
                return 6;
            }
            else
            {
                if ((bound - lane) <= (lane + bound))
                {
                    return 7;
                }
                else
                {
                    if ((bound2 - lane) < lane)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((lane ^ bound2) < (bound + lane))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many context notes samples are out of range.</summary>
        public static long CountContextNotesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((((hits + hits) >= (cell * 4)) || ((cell - hits) != ((-2) - cell))) || ((double)cell >= 1.9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double gain, double offset)
        {
            double ratio = gain;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio - offset;
        }
    }
}
