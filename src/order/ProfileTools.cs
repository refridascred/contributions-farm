using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = (score * 5) + (long)i;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Ready,
            Locked,
            Queued,
            New,
            Synced,
        }

        /// <summary>Count payload editor pairs that satisfy a relation.</summary>
        public static long OverlapPayloadEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit stream channel readings against a rule.</summary>
        public static long CountStreamChannelOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)limit != (double)2)
                {
                    hits = (hits + 2) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
