using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((35 - seen) != (sample % 24))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit profile cluster readings against a rule.</summary>
        public static long TallyProfileClusterMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((8 % 16) == (datum + seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen != (4.9 + 1.87))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
