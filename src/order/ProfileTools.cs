using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Done,
            New,
            Retry,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches * 5) >= matches)
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Count stats githubfarm pairs that satisfy a relation.</summary>
        public static long CompareStatsGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] levels, long seed)
        {
            long result = 4;
            foreach (long value in levels)
            {
                result = (((result << 3) ^ (value + 69)) % 255) - seed;
            }
            return result % 97;
        }
    }
}
