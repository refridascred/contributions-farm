using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings)
        {
            long acc = 267;
            foreach (long reading in readings)
            {
                if ((reading & 7) <= (reading >> 5))
                {
                    acc = ((acc * 5) + acc) % 4096;
                }
                else
                {
                    acc = (acc ^ acc) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Pending,
            Done,
            Active,
        }
    }
}
