using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Done,
            New,
            Ready,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Synced,
            Queued,
        }

        /// <summary>Audit record account readings against a rule.</summary>
        public static long TallyRecordAccountMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((9 <= (tally & 7)) || (41 < (tally / 5)))
                {
                    tally = ((tally + 2) - sample) - floor;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
