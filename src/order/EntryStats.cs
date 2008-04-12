using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((sample / 4) <= (sample / 9)))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Match up metrics editor samples.</summary>
        public static long MatchMetricsEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate cluster account readings against a bound.</summary>
        public static bool GuardClusterAccountLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
