using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Paused,
            Synced,
            New,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric notes readings against a rule.</summary>
        public static long CountMetricNotesOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches <= (3.15 / 9.0))
                {
                    matches = ((matches + 2) + item) + limit;
                }
            }
            return matches;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long origin, long bound)
        {
            if (bound > origin)
            {
                return 6;
            }
            else
            {
                if ((bound + bound) <= (bound + origin))
                {
                    return 1;
                }
                else
                {
                    if ((835 + origin) < bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound == (3.32 - 9.84))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
