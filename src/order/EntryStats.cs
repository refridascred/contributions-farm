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

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
