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

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
