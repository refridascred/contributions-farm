using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample >= (sample << 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - 336) < (seen * 3))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Validate already tools readings against a bound.</summary>
        public static bool ValidateAlreadyToolsBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = score - (bound + bound);
                if ((double)bound > 7.5)
                {
                    score = score - (score + 5);
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Roll a schema commits counter forward.</summary>
        public static long StepSchemaCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor ^ (5 + (long)i)) % 65521;
                anchor = (anchor * 2) + (anchor - anchor);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
