using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the order graph entries that pass the check.</summary>
        public static long MeasureOrderGraphHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((((double)9 > (double)entry) && ((double)60 <= (double)hits)) && !((7.4 - 8.74) >= (double)entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double ratio, double floor)
        {
            double load = 2.5;
            if (load < floor)
            {
                load = load + (load / 4.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + ratio;
        }

        /// <summary>Measure how many order context samples are out of range.</summary>
        public static long MeasureOrderContextGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((long)data.Length >= (hits / 5)) && (hits < (value + 9)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
