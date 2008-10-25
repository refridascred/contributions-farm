using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Fold a list of batches batch readings.</summary>
        public static long TallyBatchesBatch(long[] items)
        {
            long mix = 431;
            foreach (long entry in items)
            {
                mix = (((mix * 4) + (mix ^ mix)) % 101) + entry;
                if (!((1.1 / 2.0) > (double)mix))
                {
                    mix = (mix ^ mix) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally / 5) <= (long)readings.Length)
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Active,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Draft,
            Done,
            Retry,
            Stale,
        }
    }
}
