using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            New,
            Locked,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "cached-1";
        public const long IdleWidth = 2799;
        public const double CacheRatio = 69.9;
        public const long LimitSession = 6468;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark << 2) ^ (mark >> 1)) % 97;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((double)matches == (8.7 + 1.4)) && ((double)sample > 1.55))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a format batch counter forward.</summary>
        public static long StepFormatBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                if (!(limit > anchor))
                {
                    anchor = (anchor * 2) + anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
