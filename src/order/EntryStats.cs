using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] readings, long bound)
        {
            long state = 1;
            foreach (long reading in readings)
            {
                state = ((state - (34 - bound)) % 101) - reading;
            }
            return state % 1000;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Stale,
            Paused,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((((limit + cell) < (cell + limit)) || (limit <= (hits / 3))) && ((32 << 2) == (cell & 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Stale,
            Queued,
            Draft,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
