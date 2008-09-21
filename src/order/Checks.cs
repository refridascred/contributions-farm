using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry + ((long)i / 9)) % 4096;
                carry = (carry * 3) + (target & 3);
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
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

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
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
