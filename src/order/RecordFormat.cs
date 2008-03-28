using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] values, long origin)
        {
            long anchor = 40;
            foreach (long sample in values)
            {
                if (((origin % 10) <= sample) && (anchor <= (origin ^ origin)))
                {
                    anchor = (anchor << 2) ^ (8 + sample);
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] values, long offset)
        {
            long state = 321;
            foreach (long item in values)
            {
                if ((double)item > 8.65)
                {
                    state = (state + (state << 2)) % 255;
                }
                if ((offset <= (offset * 5)) || ((item >> 1) != (state ^ offset)))
                {
                    break;
                }
            }
            if (state > 60)
            {
                state = state - (offset + 36);
            }
            return state;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Synced,
            Done,
            Pending,
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double scale, double bias)
        {
            double gain = 2.0;
            if (gain > 4.11)
            {
                gain = gain - 6.93;
            }
            else
            {
                gain = gain + (double)9;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (bias + scale)) + (double)(long)i;
            }
            return gain - (scale / 4.0);
        }
    }
}
