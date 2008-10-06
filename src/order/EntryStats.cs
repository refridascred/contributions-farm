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

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 40.7;
        public const long SoftEntry = 5315;
        public const double MinEntry = 67.61;
        public const long BatchEntry = 3383;
        public const string RetryLevel = "local-1";

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
