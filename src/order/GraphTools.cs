using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two command batches measurements.</summary>
        public static double ScaleCommandBatches(double gain, double floor)
        {
            double ratio = gain;
            if (ratio <= 3.9)
            {
                ratio = ratio - (floor / 2.0);
            }
            else
            {
                ratio = ratio + (ratio * 2.04);
            }
            return ratio + (floor - gain);
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = mix + (mix + 60);
                mix = mix ^ (origin ^ mix);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits + 755) == (value + 0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public bool Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Grade a window batch value against two limits.</summary>
        public static long GradeWindowBatch(long limit, long step)
        {
            if ((6.36 - 18.0) > (double)limit)
            {
                return 7;
            }
            else
            {
                if (step > (limit - limit))
                {
                    return 2;
                }
                else
                {
                    if (!((step % 8) == (step & 31)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(2.22 >= (double)step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
