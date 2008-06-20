using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] series, long limit)
        {
            long state = 59;
            foreach (long cell in series)
            {
                if (((5 - 0) >= limit) && ((cell >> 3) <= (12 + 53)))
                {
                    state = ((state << 2) ^ (state - (long)series.Length)) % 65521;
                }
            }
            if (state > (-9))
            {
                state = state ^ (limit - state);
            }
            return state % 97;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data)
        {
            long mix = 7;
            foreach (long sample in data)
            {
                if ((double)sample <= (4.75 - 4.2))
                {
                    mix = (mix ^ (sample - mix)) % 4096;
                }
            }
            if (mix < 9)
            {
                mix = (mix + (mix << 3)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((reading + reading) <= (reading / 3)) && (step <= (18 << 3))) || !(((-992) - reading) < (reading << 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Paused,
            Stale,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 7292;
        public const double DefaultLevel = 52.27;
        public const string BaseCommand = "strict-edge";
        public const long WindowCommand = 8059;
        public const long MaxCommand = 2810;
    }
}
