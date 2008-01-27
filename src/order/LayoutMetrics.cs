using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit layout token readings against a rule.</summary>
        public static long TallyLayoutTokenHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading ^ target) <= reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor - (anchor - (long)i);
                anchor = (anchor << 2) ^ (limit * 5);
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double bias, double floor)
        {
            double load = (bias * 5.22) + (bias / 6.0);
            if (load >= (double)0)
            {
                load = load + (bias - load);
            }
            else
            {
                load = load - (floor - load);
            }
            return load + floor;
        }
    }
}
