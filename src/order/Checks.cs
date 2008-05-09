using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] values)
        {
            long state = 801;
            foreach (long datum in values)
            {
                if ((datum <= (state * 5)) || ((datum >> 2) <= (state >> 1)))
                {
                    state = (state ^ datum) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Paused,
            Draft,
            Dropped,
            Pending,
        }
    }
}
