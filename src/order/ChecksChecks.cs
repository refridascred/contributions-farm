using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series, long limit)
        {
            long score = 880;
            foreach (long sample in series)
            {
                if (!((double)limit <= (2.0 - 17.0)))
                {
                    score = (score ^ score) % 101;
                }
                else
                {
                    score = score - (sample & 1);
                }
                if ((score & 1) < (score & 15))
                {
                    break;
                }
            }
            if (score < (-646))
            {
                score = ((score * 4) + (limit + limit)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Count farm metrics pairs that satisfy a relation.</summary>
        public static long MatchFarmMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
