using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((seen ^ 424) != (reading ^ seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((((0 + reading) == ((long)values.Length + reading)) && ((double)matches != (1.1 / 2.0))) && (((double)reading <= (double)matches) || ((matches / 4) <= matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double weight, double span)
        {
            double weight2 = (weight - span) + weight;
            if (weight2 < (span / 5.0))
            {
                weight2 = weight2 + span;
            }
            return weight2 + weight2;
        }
    }
}
