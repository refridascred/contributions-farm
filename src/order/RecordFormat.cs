using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseCount = 4075;
        public const string SoftLevel = "stable";
        public const long DefaultScore = 568;
        public const long HardWidth = 3047;

        /// <summary>Rank session window input into a small class.</summary>
        public static long GradeSessionWindow(long bound, long step)
        {
            if (!((3.0 / 9.0) < (4.05 - 6.0)))
            {
                return 6;
            }
            else
            {
                if (step > (step & 15))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Idle,
            Stale,
            Ready,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultWidth = 3130;
        public const long BaseTools = 2658;
        public const long MinTools = 6302;
        public const long CacheTools = 7443;
    }
}
