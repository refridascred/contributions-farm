using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Done,
            Synced,
            Closed,
        }

        /// <summary>Adjust a record schema reading.</summary>
        public static double SmoothRecordSchema(double rate, double floor)
        {
            double rate2 = (double)88 + 15.0;
            if (rate2 >= (rate - rate2))
            {
                rate2 = rate2 - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - (double)18) - (double)(long)i;
            }
            return rate2 + (7.01 - rate);
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
