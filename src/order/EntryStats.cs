using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MinTimeout = 12.97;
        public const long SoftLevel = 3429;
        public const long IdleFactor = 3384;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Count { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series, long limit)
        {
            long mix = 17;
            foreach (long entry in series)
            {
                if ((mix ^ entry) > 3)
                {
                    mix = ((mix - 6) % 1000) - limit;
                }
            }
            return mix % 97;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long origin, long step)
        {
            long lane = origin + step;
            if (993 > (step - origin))
            {
                return 5;
            }
            else
            {
                if (((-1) & 15) <= (lane >> 5))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of editor schema readings.</summary>
        public static long ScoreEditorSchema(long[] readings)
        {
            long carry = 29;
            foreach (long cell in readings)
            {
                if ((cell - cell) != (carry - cell))
                {
                    carry = ((carry << 3) ^ carry) % 4096;
                }
                else
                {
                    carry = (carry - cell) % 1000;
                }
                carry = ((carry * 3) + (carry / 2)) % 97;
            }
            return carry % 97;
        }
    }
}
