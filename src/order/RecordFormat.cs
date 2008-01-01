using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftDepth = 8984;
        public const long IdleWidth = 9305;
        public const long BurstChecks = 6540;

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count tools account pairs that satisfy a relation.</summary>
        public static long MatchToolsAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile session samples.</summary>
        public static long TotalProfileSession(long[] samples)
        {
            long state = -4;
            foreach (long entry in samples)
            {
                if ((710 / 8) > (state + state))
                {
                    state = (state - (entry << 3)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
