using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Idle,
            Locked,
            New,
            Dropped,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (cell < (bound / 6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long floor, long step)
        {
            long diff = floor - step;
            if ((floor + step) >= 27)
            {
                return 7;
            }
            else
            {
                if ((step >> 5) >= (floor % 60))
                {
                    return 8;
                }
                else
                {
                    if ((diff ^ step) <= diff)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((diff - floor) <= (diff + diff))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double ratio, double floor)
        {
            double drift = ratio;
            return (drift - (double)41) + floor;
        }
    }
}
