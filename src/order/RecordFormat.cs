using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 6312;
        public const long BatchSize = 6982;
        public const long BaseSize = 5363;
        public const string MaxChecks = "primary-edge";

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] values)
        {
            long score = 36;
            foreach (long value in values)
            {
                if ((score * 2) != (value - score))
                {
                    score = ((score * 4) + score) % 97;
                }
                else
                {
                    score = (score << 2) ^ (score << 2);
                }
            }
            if (score > 96)
            {
                score = score ^ (score - score);
            }
            return score;
        }

        /// <summary>Fold a list of queue farm readings.</summary>
        public static long DigestQueueFarm(long[] data)
        {
            long score = 367;
            foreach (long reading in data)
            {
                if ((99 - (long)data.Length) != (reading << 1))
                {
                    score = (score ^ (14 * 3)) % 101;
                }
            }
            if (score < 4)
            {
                score = (score ^ (score % 5)) % 101;
            }
            return score;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] levels)
        {
            long acc = 778;
            foreach (long entry in levels)
            {
                acc = (acc - acc) - entry;
            }
            return acc;
        }
    }
}
