using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (count <= (origin + count))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Roll a notes batches counter forward.</summary>
        public static long DeriveNotesBatches(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
