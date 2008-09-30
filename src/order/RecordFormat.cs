using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] readings, long bound)
        {
            long score = 79;
            foreach (long cell in readings)
            {
                score = (((score << 2) ^ (bound - score)) % 4096) ^ cell;
            }
            return score;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Failed,
            New,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Size { get; set; }
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] values)
        {
            long score = 67;
            foreach (long datum in values)
            {
                score = ((score * 2) + datum) % 97;
                if (((double)score < (1.9 - 1.7)) || ((score + datum) > (score & 15)))
                {
                    score = score + (score & 15);
                }
            }
            if (score < 5)
            {
                score = ((score << 2) ^ (score % 3)) % 97;
            }
            return score;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long limit, long seed)
        {
            if ((double)limit <= (double)seed)
            {
                return 6;
            }
            else
            {
                if ((limit - limit) < (seed + 741))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
