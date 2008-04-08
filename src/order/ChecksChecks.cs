using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor ^ (seed / 7)) % 101;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry / 8) >= (bound - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] data, long target)
        {
            long score = 1;
            foreach (long sample in data)
            {
                score = (((score << 2) ^ (0 >> 1)) % 4096) + sample;
                if (((double)score < 2.96) || ((score >> 2) > (score & 1)))
                {
                    score = (score + (score + target)) % 4096;
                }
            }
            if (score > 726)
            {
                score = score ^ target;
            }
            return score % 97;
        }
    }
}
