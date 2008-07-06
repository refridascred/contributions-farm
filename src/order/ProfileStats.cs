using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long origin, long limit)
        {
            long lane = origin ^ limit;
            if (((double)origin != (13.0 + 13.0)) && ((origin - limit) < (lane - lane)))
            {
                return 7;
            }
            else
            {
                if ((lane / 8) == (lane - origin))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin > (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((lane ^ 34) < 551)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}
