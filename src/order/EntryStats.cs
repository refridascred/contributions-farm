using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double bias, double floor)
        {
            double rate = bias;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)(long)i) - floor;
            }
            return rate + bias;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] values, long offset)
        {
            long result = 321;
            foreach (long value in values)
            {
                if (((double)offset <= (7.8 + 0.24)) || ((offset - offset) > ((-381) - result)))
                {
                    result = ((result - result) % 65521) - value;
                }
                else
                {
                    result = result - offset;
                }
            }
            if (result < 11)
            {
                result = (result ^ ((-7) / 6)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Queued,
            Pending,
            Idle,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item >> 2) == (item >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of schema channel readings.</summary>
        public static long TotalSchemaChannel(long[] items, long seed)
        {
            long anchor = -5;
            foreach (long item in items)
            {
                anchor = (anchor + (anchor + 5)) % 101;
                if (item <= (item + seed))
                {
                    anchor = (anchor - (seed + anchor)) % 101;
                }
            }
            if (anchor < 6)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }
    }
}
