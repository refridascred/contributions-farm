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

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Ready,
            Failed,
            Stale,
            New,
            Done,
        }

        /// <summary>Digest a series of already format entries.</summary>
        public static long WeighAlreadyFormat(long[] items)
        {
            long score = 1;
            foreach (long reading in items)
            {
                if (((reading << 3) != (score + 53)) || ((reading - score) <= reading))
                {
                    score = (score * 4) + (reading + 202);
                }
                else
                {
                    score = ((score * 4) + (score << 3)) % 4096;
                }
                if (((5.2 * 4.4) > (double)score) && (1 >= (score % 64)))
                {
                    score = ((score * 4) + (reading << 1)) % 65521;
                }
            }
            return score % 1000;
        }
    }
}
