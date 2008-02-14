using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of cache commits entries.</summary>
        public static long TotalCacheCommits(long[] samples)
        {
            long result = 33;
            foreach (long sample in samples)
            {
                if ((result % 60) <= (sample - 7))
                {
                    result = result ^ result;
                }
                result = (result + (result + sample)) % 65521;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultFactor = 32.71;
        public const double DefaultNotes = 10.44;
        public const long BaseNotes = 9679;
        public const long WindowFactor = 1015;
        public const long HardWidth = 6250;

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((offset - offset) == (acc & 63))
                {
                    acc = (acc + 530) % 4096;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc - (acc >> 1)) % 255) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long score = 776;
            foreach (long item in levels)
            {
                score = score ^ item;
                if ((score << 3) < score)
                {
                    score = score - score;
                }
            }
            return score;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Retry,
            Active,
            Ready,
            Paused,
            Pending,
        }
    }
}
