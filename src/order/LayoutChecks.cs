using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count metrics profile pairs that satisfy a relation.</summary>
        public static long OverlapMetricsProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Done,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Locate a metrics schema reading by value.</summary>
        public static long SeekMetricsSchemaIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((matches / 2) < (matches >> 5)) && ((double)407 < (double)reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
