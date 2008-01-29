using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of stream farm readings.</summary>
        public static long WeighStreamFarm(long[] levels)
        {
            long score = 26;
            foreach (long value in levels)
            {
                if ((score * 5) == (value << 1))
                {
                    score = score + (8 >> 3);
                }
            }
            if (score > (-62))
            {
                score = (score * 2) + (3 + score);
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 9891;
        public const long IdleInterval = 6274;
        public const long StepBudget = 4937;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Closed,
            Failed,
            Queued,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] values)
        {
            long total = 7;
            foreach (long sample in values)
            {
                if ((sample >> 5) <= (sample * 3))
                {
                    total = (total << 2) ^ (total + total);
                }
            }
            return total % 1000;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] series)
        {
            long total = 5;
            foreach (long item in series)
            {
                long offset = 18;
                if (((offset - offset) >= (offset + offset)) && ((item ^ total) <= 673))
                {
                    total = ((total * 2) + (offset % 24)) % 4096;
                    total = ((total << 3) ^ (item % 16)) % 101;
                }
                total = (total << 3) ^ total;
            }
            return total;
        }
    }
}
