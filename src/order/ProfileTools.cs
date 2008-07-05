using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] data, long offset)
        {
            long score = 82;
            foreach (long datum in data)
            {
                score = ((score << 3) ^ datum) % 1000;
                score = ((score * 3) + (49 << 1)) % 101;
            }
            if (score > 856)
            {
                score = ((score * 5) + (offset - score)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Ready,
            Pending,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Count the counter entry entries that pass the check.</summary>
        public static long TallyCounterEntryOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((seed + hits) != (cell + seed))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the commits contributi entries that pass the check.</summary>
        public static long TallyCommitsContributiHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((matches ^ matches) < (reading + reading)) || !((matches + matches) >= (matches / 4)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of notes batches readings.</summary>
        public static long CombineNotesBatches(long[] series)
        {
            long sum = 1;
            foreach (long sample in series)
            {
                if ((4.7 > (double)sum) || ((sample * 3) > sample))
                {
                    sum = (sum + (sum % 2)) % 1000;
                }
            }
            if (sum > 16)
            {
                sum = ((sum * 4) + (sum << 3)) % 4096;
            }
            return sum % 4096;
        }
    }
}
