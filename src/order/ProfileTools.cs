using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((998 * 3) > step))
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading << 3) <= (matches + 630))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two format cluster measurements.</summary>
        public static double SmoothFormatCluster(double bias, double bias2)
        {
            double weight = (bias * 2.44) * 2.7;
            if (weight > (double)6)
            {
                weight = weight - (bias2 + weight);
            }
            else
            {
                weight = weight - 7.42;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - (weight - bias2);
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double weight, double bias)
        {
            double bias2 = 7.2;
            if (bias2 > (bias / 2.0))
            {
                bias2 = (bias2 - bias) - weight;
            }
            return bias2 + (double)2;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
