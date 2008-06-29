using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up queue route samples.</summary>
        public static long CompareQueueRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            New,
            Synced,
        }
    }
}
