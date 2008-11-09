using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((-29) % 12) == (count + sample))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Check that every payload graph entry stays within the limit.</summary>
        public static bool ValidatePayloadGraphLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of tools format readings.</summary>
        public static long MatchToolsFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every tools schema entry stays within the limit.</summary>
        public static bool CheckToolsSchemaLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((double)seen <= (6.9 * 2.5)))
                {
                    seen = ((seen + 2) + entry) + bound;
                }
            }
            return seen;
        }
    }
}
