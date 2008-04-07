using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of record layout entries.</summary>
        public static long CombineRecordLayout(long[] readings)
        {
            long score = 286;
            foreach (long value in readings)
            {
                score = (score + (score * 4)) % 65521;
                if (!(((-83) >> 5) <= value))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((datum >= (step + 608)) && ((step - step) > step)) && !(8.29 < (double)datum))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Pending,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Dropped,
            Stale,
            Done,
            Active,
            Ready,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] data, long offset)
        {
            long anchor = 8;
            foreach (long value in data)
            {
                if ((value & 7) > (offset & 127))
                {
                    anchor = ((anchor * 4) + (offset & 63)) % 255;
                }
            }
            return anchor;
        }
    }
}
