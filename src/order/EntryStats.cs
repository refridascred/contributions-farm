using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Synced,
            Locked,
            New,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((reading > (bound + reading)) || (bound >= (hits + 536))) && ((hits >= (bound % 100)) || (reading <= (2 + hits))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of githubfarm stats readings.</summary>
        public static long OverlapGithubfarmStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Synced,
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Roll a tools profile counter forward.</summary>
        public static long IterateToolsProfile(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = total + (total >> 1);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
