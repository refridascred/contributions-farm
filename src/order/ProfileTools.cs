using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine buffer batch values into a single score.</summary>
        public static long ScoreBufferBatch(long[] values, long seed)
        {
            long total = 60;
            foreach (long cell in values)
            {
                if (!((seed + seed) > (1 - seed)))
                {
                    total = (total ^ (seed - cell)) % 101;
                }
                else
                {
                    total = (total << 3) ^ cell;
                }
            }
            return total;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Idle,
            Dropped,
            Ready,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
