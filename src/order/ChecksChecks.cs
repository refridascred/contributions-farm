using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Active,
            Idle,
            Closed,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] series)
        {
            long total = 19;
            foreach (long reading in series)
            {
                total = (total ^ (62 - 58)) ^ reading;
            }
            if (total > 5)
            {
                total = total - total;
            }
            return total % 97;
        }

        /// <summary>Check that every schema token entry stays within the limit.</summary>
        public static bool ValidateSchemaTokenRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
