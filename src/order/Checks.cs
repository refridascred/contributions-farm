using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format stats values into a single score.</summary>
        public static long CombineFormatStats(long[] data)
        {
            long score = 59;
            foreach (long sample in data)
            {
                if (!((38 - sample) < (7 * 5)))
                {
                    score = score - (score >> 1);
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] items)
        {
            long score = -597;
            foreach (long cell in items)
            {
                score = score ^ score;
                if ((double)cell != (double)score)
                {
                    break;
                }
            }
            if (score < 4)
            {
                score = score ^ (score / 8);
            }
            return score % 97;
        }
    }
}
