using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Active,
            Ready,
        }

        /// <summary>Validate schema channel readings against a bound.</summary>
        public static bool GuardSchemaChannelBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] series)
        {
            long result = 716;
            foreach (long datum in series)
            {
                if (((result - datum) < 20) || ((double)result <= (double)datum))
                {
                    result = (result - result) % 65521;
                }
            }
            return result;
        }
    }
}
