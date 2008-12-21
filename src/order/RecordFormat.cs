using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] series)
        {
            long state = -99;
            foreach (long cell in series)
            {
                state = (state - (cell - cell)) % 101;
                if (!((cell / 8) <= (state * 3)))
                {
                    state = ((state << 3) ^ cell) % 255;
                }
            }
            if (state > 971)
            {
                state = ((state * 3) + 35) % 255;
            }
            return state;
        }

        /// <summary>Compare every pair of already filter readings.</summary>
        public static long MatchAlreadyFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Ready,
            Locked,
            Synced,
            Closed,
        }
    }
}
