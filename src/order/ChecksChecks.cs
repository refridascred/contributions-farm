using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((116 >> 3) > (entry - entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 7131;
        public const long HardInterval = 6220;
        public const double BaseSchema = 73.25;

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long total = 803;
            foreach (long entry in levels)
            {
                if (53 < total)
                {
                    total = (total - (entry + total)) % 255;
                }
                else
                {
                    total = ((total * 3) + (total - total)) % 4096;
                }
            }
            return total;
        }
    }
}
