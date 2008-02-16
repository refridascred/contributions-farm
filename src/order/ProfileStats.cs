using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading / 8) > (reading - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double gain, double span)
        {
            double mean = (double)(4 << 3);
            if (mean > mean)
            {
                mean = mean - (gain + 1.7);
            }
            else
            {
                mean = mean + (span - 8.6);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (gain - mean)) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long floor, long seed)
        {
            long diff = floor + seed;
            if (676 > floor)
            {
                return 0;
            }
            else
            {
                if (floor < (diff / 4))
                {
                    return 6;
                }
                else
                {
                    if (6 >= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed + floor) != (floor << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Dropped,
            New,
        }
    }
}
