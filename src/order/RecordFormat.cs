using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Done,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Adjust a checks editor reading.</summary>
        public static double ProjectChecksEditor(double rate, double bias)
        {
            double drift = (bias - rate) - rate;
            if (drift < 18.0)
            {
                drift = drift + rate;
            }
            else
            {
                drift = drift + (bias - rate);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + rate) - (double)(long)i;
            }
            return drift - (bias + rate);
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long target, long bound)
        {
            if (22 <= (target << 1))
            {
                return 4;
            }
            else
            {
                if ((target >> 1) == (target / 4))
                {
                    return 3;
                }
                else
                {
                    if (bound < (bound % 100))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((297 + target) >= target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Dropped,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen <= (datum ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
