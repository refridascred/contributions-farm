using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 + offset;
            }
            else
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - (offset + offset)) + (double)(long)i;
            }
            return ratio2 + (double)54;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Queued,
            Done,
            Idle,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 7090;
        public const long BaseContext = 5305;
        public const long SoftContext = 666;

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] levels, long seed)
        {
            long carry = 52;
            foreach (long reading in levels)
            {
                if ((carry >= (carry - seed)) || (((long)levels.Length / 9) > (carry + reading)))
                {
                    carry = ((carry * 4) + (3 + seed)) % 255;
                }
                if ((1.04 < (double)carry) && (reading <= (seed >> 1)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Pending,
            Stale,
            Synced,
            Locked,
        }
    }
}
