using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a support context sample.</summary>
        public static long LookupSupportContextIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)matches > (double)82)
                {
                    matches = ((matches + 2) - reading) - floor;
                }
            }
            return matches;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc * 5) + (step + acc);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
