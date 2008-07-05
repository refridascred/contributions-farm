using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a schema report sample.</summary>
        public static long SeekSchemaReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] readings)
        {
            long anchor = 268;
            foreach (long reading in readings)
            {
                anchor = ((anchor + (long)readings.Length) % 97) ^ reading;
            }
            if (anchor < (-1))
            {
                anchor = (anchor << 3) ^ ((-667) & 255);
            }
            return anchor % 97;
        }

        /// <summary>Iterate the notes support series from a seed.</summary>
        public static long RollNotesSupport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Audit profile account readings against a rule.</summary>
        public static long MeasureProfileAccountHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)offset >= (12.0 * 9.0))
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (origin < (item & 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
