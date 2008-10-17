using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = score - (score % 16);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(((cell + 62) == (seen / 4)) || ((seen + seen) == (cell >> 1))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor ^ (642 & 255);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Pending,
            Active,
        }
    }
}
