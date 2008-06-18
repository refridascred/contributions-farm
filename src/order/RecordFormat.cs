using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] samples, long seed)
        {
            long anchor = 54;
            foreach (long item in samples)
            {
                if ((seed % 64) > 0)
                {
                    anchor = (anchor << 2) ^ (item + anchor);
                }
                if ((seed * 2) <= (736 + item))
                {
                    break;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor << 2) ^ ((long)samples.Length - anchor)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Done,
            Queued,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (step < (item / 9))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double rate, double offset)
        {
            double drift = (double)406 * 4.0;
            if (drift >= drift)
            {
                drift = drift + (double)905;
            }
            else
            {
                drift = drift - offset;
            }
            return drift + (rate + offset);
        }
    }
}
