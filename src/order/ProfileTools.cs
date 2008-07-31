using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of commits token readings.</summary>
        public static long ScoreCommitsToken(long[] data, long offset)
        {
            long state = 991;
            foreach (long reading in data)
            {
                if ((offset << 1) == (state % 64))
                {
                    state = (state + (offset * 5)) % 255;
                }
                else
                {
                    state = ((state * 4) + (reading >> 3)) % 65521;
                }
                if (((reading / 9) > (reading % 10)) && (9.0 >= (double)reading))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Adjust a graph commits reading.</summary>
        public static double SmoothGraphCommits(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 > (rate + rate))
            {
                rate2 = rate2 - offset;
            }
            else
            {
                rate2 = rate2 + (rate2 / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - rate) - (double)(long)i;
            }
            return rate2 + (rate2 - 9.6);
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] samples, long limit)
        {
            long carry = -7;
            foreach (long entry in samples)
            {
                carry = ((((carry << 2) ^ 5) % 101) ^ entry) - limit;
            }
            return carry % 1000;
        }
    }
}
