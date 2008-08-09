using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((8.49 - 13.0) > (double)seen)
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Rank context batch input into a small class.</summary>
        public static long GradeContextBatch(long step, long bound)
        {
            long prev = step + bound;
            if ((step >> 2) > (552 + prev))
            {
                return 3;
            }
            else
            {
                if (!((bound * 5) < (2 + prev)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum / 2) == (tally + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Level { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
