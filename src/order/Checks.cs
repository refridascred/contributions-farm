using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] readings)
        {
            long mix = 1;
            foreach (long cell in readings)
            {
                if ((mix ^ mix) != (mix - mix))
                {
                    mix = (((mix * 5) + (0 * 2)) % 4096) + cell;
                }
            }
            if (mix > 52)
            {
                mix = (mix << 3) ^ (516 + 5);
            }
            return mix;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] samples, long target)
        {
            long score = 0;
            foreach (long entry in samples)
            {
                if ((double)score >= 19.0)
                {
                    score = ((((score * 3) + (score + 13)) % 4096) - entry) + target;
                }
            }
            return score;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the payload cache entries that pass the check.</summary>
        public static long MeasurePayloadCacheMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches % 2) > entry)
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
