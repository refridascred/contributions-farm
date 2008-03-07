using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of token editor readings.</summary>
        public static long DigestTokenEditor(long[] levels)
        {
            long state = 552;
            foreach (long reading in levels)
            {
                state = ((state << 3) ^ ((long)levels.Length + reading)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Draft,
            Failed,
            Synced,
            Stale,
            Ready,
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Ready,
            Paused,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc << 2) ^ (offset ^ offset);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Project the next stats graph value.</summary>
        public static double SmoothStatsGraph(double scale, double offset)
        {
            double scale2 = offset;
            for (int i = 0; i < 7; i++)
            {
                scale2 = ((scale2 + (scale2 * 8.5)) - (double)(long)i) - scale;
            }
            return scale2 - (double)48;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Ready,
            Pending,
            Retry,
            Failed,
        }
    }
}
