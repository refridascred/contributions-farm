using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] series)
        {
            long mix = -45;
            foreach (long sample in series)
            {
                if (mix >= (sample << 2))
                {
                    mix = ((mix * 4) + (sample + sample)) % 97;
                }
                else
                {
                    mix = mix - (sample >> 4);
                }
            }
            return mix;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((matches & 255) < (-2)))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Check that every report batch entry stays within the limit.</summary>
        public static bool VerifyReportBatchRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Failed,
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Audit account graph readings against a rule.</summary>
        public static long CountAccountGraphMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits + bound) != (15 & 127))
                {
                    hits = (hits + 3) ^ sample;
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
