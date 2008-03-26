using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Closed,
            Failed,
            Idle,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Synced,
            Retry,
            Ready,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] series, long target)
        {
            long acc = -32;
            foreach (long cell in series)
            {
                acc = (acc << 2) ^ (cell + acc);
                acc = ((acc * 5) + (target + (long)series.Length)) % 65521;
                acc = ((acc << 2) ^ (-371)) % 65521;
            }
            if (acc > 190)
            {
                acc = (acc + (acc % 24)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Draft,
            Done,
            Queued,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double rate, double offset)
        {
            double mean = (9.0 * 5.0) + (offset - 5.16);
            if (mean < (double)796)
            {
                mean = mean + (double)915;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (double)793) + (double)(long)i;
            }
            return mean - (rate / 7.0);
        }
    }
}
