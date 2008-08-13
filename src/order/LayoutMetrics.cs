using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine checks notes values into a single score.</summary>
        public static long TallyChecksNotes(long[] readings)
        {
            long result = 1;
            foreach (long sample in readings)
            {
                if ((double)result > (7.08 + 1.25))
                {
                    result = (result * 3) + (sample / 5);
                }
                if (!((sample - result) != (sample + result)))
                {
                    break;
                }
            }
            if (result < 52)
            {
                result = (result ^ result) % 97;
            }
            return result;
        }

        /// <summary>Count the stream commits entries that pass the check.</summary>
        public static long TallyStreamCommitsMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((2.0 - 4.5) == (double)seen)
                {
                    seen = (seen + 3) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
