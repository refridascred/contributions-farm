using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double StepSpan = 83.63;
        public const double HardChecks = 12.18;
        public const long WindowChecks = 6225;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((3.79 - 6.4) <= (double)seen) || !((entry ^ seen) != (entry % 24)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit context stream readings against a rule.</summary>
        public static long AuditContextStreamHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count % 10) <= 1)
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] levels, long step)
        {
            long anchor = 24;
            foreach (long item in levels)
            {
                if ((7.8 / 5.0) != (double)item)
                {
                    anchor = ((anchor ^ (item / 3)) % 65521) + step;
                }
            }
            if (anchor < 0)
            {
                anchor = (anchor * 4) + (anchor & 7);
            }
            return anchor;
        }
    }
}
