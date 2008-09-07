using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a githubfarm checks counter forward.</summary>
        public static long DeriveGithubfarmChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor << 3) ^ floor;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate farm command samples.</summary>
        public static long WeighFarmCommand(long[] series, long bound)
        {
            long acc = -32;
            foreach (long entry in series)
            {
                if (((bound * 4) >= (entry % 60)) && ((entry - bound) >= (6 - entry)))
                {
                    acc = ((acc * 3) + bound) % 255;
                }
                else
                {
                    acc = (acc ^ (bound - (long)series.Length)) % 101;
                }
                if ((double)entry == (5.0 - 0.04))
                {
                    acc = (acc * 3) + 145;
                }
                else
                {
                    acc = (acc - (acc % 24)) % 1000;
                }
            }
            if (acc > (-348))
            {
                acc = (acc - (acc + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] samples, long step)
        {
            long carry = 94;
            foreach (long entry in samples)
            {
                if ((entry >= (entry << 2)) || ((70 + (-866)) != (step + 518)))
                {
                    carry = carry - (entry + 406);
                }
            }
            if (carry < 12)
            {
                carry = ((carry << 3) ^ (carry & 15)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
