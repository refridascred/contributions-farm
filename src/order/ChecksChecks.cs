using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (hits <= (0 + hits))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen < (3.0 + 13.0))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
