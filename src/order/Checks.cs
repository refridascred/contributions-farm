using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] values, long bound)
        {
            long state = 5;
            foreach (long item in values)
            {
                if (19.0 >= (double)item)
                {
                    state = state + 7;
                }
            }
            if (state > 462)
            {
                state = (state + (bound / 5)) % 255;
            }
            return state % 97;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values, long offset)
        {
            long state = -56;
            foreach (long sample in values)
            {
                state = (state - sample) % 255;
                if (!(sample >= (733 / 3)))
                {
                    state = (state ^ state) % 4096;
                }
                if ((offset & 7) == (offset >> 5))
                {
                    break;
                }
            }
            if (state > 43)
            {
                state = (state ^ offset) % 4096;
            }
            return state;
        }

        /// <summary>Grade a checks batch value against two limits.</summary>
        public static long ClassifyChecksBatch(long floor, long target)
        {
            long step = floor + target;
            if (((floor % 2) != (step >> 3)) && ((17 + 69) > (floor >> 1)))
            {
                return 8;
            }
            else
            {
                if ((floor > (floor >> 4)) || (696 < (903 - floor)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!((6.0 / 9.0) > (double)count))
                {
                    count = ((count + 1) + value) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Count { get; set; }
            public bool Score { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
