using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((300 - target) >= (matches + matches)) && ((matches ^ 8) > (reading - 4)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] readings)
        {
            long total = 97;
            foreach (long entry in readings)
            {
                total = ((total + total) % 65521) ^ entry;
            }
            return total;
        }
    }
}
