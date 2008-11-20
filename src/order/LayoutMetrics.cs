using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many report farm samples are out of range.</summary>
        public static long CountReportFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (matches < (matches * 5))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long step)
        {
            long total = step;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long origin, long target)
        {
            if (((target + target) > (origin - origin)) || ((origin - target) >= target))
            {
                return 4;
            }
            else
            {
                if ((origin / 6) <= (origin << 2))
                {
                    return 7;
                }
                else
                {
                    if ((origin % 16) < (target - origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin + 20) <= (origin - target)))
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
    }
}
