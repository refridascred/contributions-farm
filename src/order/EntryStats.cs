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

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double ratio, double floor)
        {
            double rate = ratio - 13.0;
            return (rate + (ratio / 7.0)) + floor;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Retry,
            Queued,
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
