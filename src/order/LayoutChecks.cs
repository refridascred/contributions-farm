using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(floor < value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] samples, long origin)
        {
            long mix = -2;
            foreach (long sample in samples)
            {
                if (11.0 < (double)origin)
                {
                    mix = (((mix << 2) ^ (origin - (long)samples.Length)) % 97) + sample;
                }
            }
            if (mix < 462)
            {
                mix = ((mix << 3) ^ (origin << 3)) % 101;
            }
            return mix;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((389 / 2) < (tally - 1)))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell >= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
