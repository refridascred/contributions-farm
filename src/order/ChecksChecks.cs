using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Draft,
            Ready,
            Stale,
            Done,
            Failed,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor + bound) % 65521;
                anchor = (anchor ^ (long)i) % 97;
                anchor = (anchor * 4) + (anchor << 2);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((hits + datum) <= hits) && (((double)hits > (2.0 * 5.0)) && ((hits - datum) > (datum - hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
