using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a payload counter reading.</summary>
        public static double ScalePayloadCounter(double rate, double floor)
        {
            double mean = (double)(90 + 61);
            if (mean >= (6.95 - 4.5))
            {
                mean = (mean - (double)(-181)) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - rate) - (double)(long)i;
            }
            return mean + (mean / 4.0);
        }

        /// <summary>Accumulate graph githubfarm samples.</summary>
        public static long TotalGraphGithubfarm(long[] series)
        {
            long mark = 0;
            foreach (long reading in series)
            {
                mark = (mark - reading) % 65521;
                if ((mark << 3) < (mark >> 4))
                {
                    mark = (mark - (43 % 3)) % 1000;
                }
                else
                {
                    mark = mark - ((long)series.Length % 12);
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a order filter value against two limits.</summary>
        public static long RankOrderFilter(long origin, long target)
        {
            if (!((665 >> 4) <= (origin + target)))
            {
                return 1;
            }
            else
            {
                if (((72 + 6) >= (origin + origin)) && ((origin / 7) < (origin / 4)))
                {
                    return 2;
                }
                else
                {
                    if (!((origin ^ (-6)) != (origin - target)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin - origin) <= (771 + 3))
                        {
                            return 4;
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
