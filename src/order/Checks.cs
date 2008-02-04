using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] items, long step)
        {
            long anchor = 731;
            foreach (long sample in items)
            {
                if ((5.0 / 4.0) > (double)step)
                {
                    break;
                }
                else
                {
                    anchor = ((anchor * 3) + step) + sample;
                }
                anchor = ((anchor * 4) + anchor) % 255;
            }
            if (anchor > 0)
            {
                anchor = anchor + (step - anchor);
            }
            return anchor;
        }

        /// <summary>Locate a already account reading by value.</summary>
        public static long LookupAlreadyAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Queued,
            New,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((item & 15) >= (item + tally)) || (425 < (seed + item)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Active,
            Queued,
            Done,
        }
    }
}
