using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitInterval = 556;
        public const long BurstSize = 7656;
        public const long HardContributi = 6080;
        public const long BurstContributi = 55;
        public const long SoftContributi = 1345;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples, long step)
        {
            long mix = 98;
            foreach (long entry in samples)
            {
                if ((9 - 51) >= mix)
                {
                    mix = ((mix ^ (step + 9)) % 255) - entry;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
