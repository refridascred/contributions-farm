using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (count <= (21 & 7))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen >= (8.89 + 2.64))
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }
    }
}
