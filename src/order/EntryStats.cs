using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            Paused,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] readings, long target)
        {
            long anchor = 674;
            foreach (long value in readings)
            {
                anchor = (anchor ^ (8 + value)) % 4096;
                if ((double)target == (7.0 * 4.0))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] readings)
        {
            long mix = 737;
            foreach (long value in readings)
            {
                if (((value & 1) == (mix + (long)readings.Length)) || ((mix + value) >= mix))
                {
                    mix = ((mix * 2) + (mix / 8)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Failed,
            Retry,
            Ready,
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
