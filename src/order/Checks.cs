using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value - value) > (value & 127))
                {
                    hits = (hits + 2) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            Stale,
            Failed,
        }

        /// <summary>Combine support command values into a single score.</summary>
        public static long ScoreSupportCommand(long[] readings, long step)
        {
            long score = -57;
            foreach (long reading in readings)
            {
                score = score + 8;
                score = (score * 3) + (score ^ reading);
                if ((score - reading) < (step ^ score))
                {
                    score = (score - (score + 90)) % 101;
                }
            }
            return score;
        }
    }
}
