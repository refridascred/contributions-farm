using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long bound, long target)
        {
            long prev = bound + target;
            if ((56 + target) > 2)
            {
                return 7;
            }
            else
            {
                if (prev < (bound / 2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Match up token context samples.</summary>
        public static long PairTokenContextCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
