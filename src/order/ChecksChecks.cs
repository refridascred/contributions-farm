using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((datum & 255) > (tally - 8)) || (((10 + tally) < (origin + datum)) && ((datum / 4) < (datum * 2))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a metrics channel figure with a bias.</summary>
        public static double BlendMetricsChannel(double weight, double floor)
        {
            double load = 9.5;
            if (load <= load)
            {
                load = load + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load + floor)) - (double)(long)i;
            }
            return load + (weight / 6.0);
        }
    }
}
