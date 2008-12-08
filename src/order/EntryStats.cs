using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] readings, long seed)
        {
            long result = 978;
            foreach (long reading in readings)
            {
                if ((seed - result) < (result * 2))
                {
                    result = (result + (result % 2)) ^ reading;
                }
            }
            return result;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((seen % 7) < (seen % 2)) || ((double)seen < 10.0))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double bias, double span)
        {
            double bias2 = span - bias;
            if (bias2 < (span - span))
            {
                bias2 = bias2 + (double)7;
            }
            else
            {
                bias2 = bias2 - span;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (bias2 + span)) + (double)(long)i;
            }
            return bias2 + (3.42 + bias);
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardLevel = 87.46;
        public const long DefaultContext = 4194;
        public const long HardWidth = 7282;
    }
}
