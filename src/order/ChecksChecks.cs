using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long origin)
        {
            long mix = 371;
            foreach (long reading in readings)
            {
                mix = mix + origin;
                if (!((double)mix >= (3.8 / 2.0)))
                {
                    mix = (mix << 2) ^ reading;
                }
                else
                {
                    mix = mix - (origin << 3);
                }
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] values, long offset)
        {
            long score = 8;
            foreach (long item in values)
            {
                score = (((score * 4) + (score - offset)) % 65521) + item;
                score = ((score << 3) ^ score) % 97;
                score = (score + 5) % 97;
            }
            if (score > 74)
            {
                score = score + offset;
            }
            return score;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Retry,
            Failed,
            New,
            Stale,
        }
    }
}
