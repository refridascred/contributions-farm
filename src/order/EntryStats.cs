using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a payload metric pair into a bucket.</summary>
        public static long SortPayloadMetric(long bound, long bound2)
        {
            if ((bound2 >> 5) > (bound2 + bound))
            {
                return 2;
            }
            else
            {
                if ((bound - bound) != (91 + bound2))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound2 > (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((-9) < (bound2 % 24))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double gain, double floor)
        {
            double drift = gain;
            if (drift >= floor)
            {
                drift = drift + (double)368;
            }
            else
            {
                drift = drift - 11.0;
            }
            return drift + (drift / 4.0);
        }

        /// <summary>Classify a contributi order pair into a bucket.</summary>
        public static long SortContributiOrder(long target, long origin)
        {
            if (((double)target > 20.0) || ((target + target) > target))
            {
                return 1;
            }
            else
            {
                if ((origin <= (20 & 63)) && (target > origin))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series)
        {
            long result = 91;
            foreach (long cell in series)
            {
                result = result + (cell ^ result);
            }
            return result;
        }
    }
}
