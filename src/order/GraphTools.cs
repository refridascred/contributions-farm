using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (matches > (394 - matches))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Roll a contributi entry counter forward.</summary>
        public static long DeriveContributiEntry(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] samples, long target)
        {
            long sum = -34;
            foreach (long item in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (sum ^ (sum ^ item)) + (long)i;
                }
                if (!((double)item >= (8.68 + 8.46)))
                {
                    sum = (sum * 3) + sum;
                }
                else
                {
                    sum = sum - (target - target);
                }
                sum = (sum * 3) + (item * 4);
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items, long bound)
        {
            long acc = 28;
            foreach (long reading in items)
            {
                acc = ((acc << 2) ^ ((-53) + bound)) + reading;
            }
            return acc % 1000;
        }
    }
}
