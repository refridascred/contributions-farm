using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = (score * 5) + (long)i;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Rank { get; set; }
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Derive the next support report value from a seed.</summary>
        public static long StepSupportReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count payload editor pairs that satisfy a relation.</summary>
        public static long OverlapPayloadEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit stream channel readings against a rule.</summary>
        public static long CountStreamChannelOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)limit != (double)2)
                {
                    hits = (hits + 2) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
