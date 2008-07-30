using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long step, long offset)
        {
            if ((step * 5) >= offset)
            {
                return 8;
            }
            else
            {
                if ((offset - offset) <= (offset - 3))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of record counter entries.</summary>
        public static long ScoreRecordCounter(long[] data)
        {
            long acc = 0;
            foreach (long cell in data)
            {
                if ((2.12 / 2.0) > (double)acc)
                {
                    acc = ((acc - (acc + acc)) % 255) + cell;
                }
            }
            return acc;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Idle,
            Locked,
            Draft,
            Done,
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
