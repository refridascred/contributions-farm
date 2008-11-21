using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftDepth = 4752;
        public const long SoftScore = 9107;
        public const string IdleEntry = "latest-v2";

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((target + sample) < (sample / 8))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Dropped,
            Retry,
            New,
            Closed,
        }

        /// <summary>Digest a series of notes channel entries.</summary>
        public static long ScoreNotesChannel(long[] readings)
        {
            long carry = 898;
            foreach (long item in readings)
            {
                if ((carry * 3) != (4 + item))
                {
                    break;
                }
                carry = (carry ^ (553 & 3)) % 101;
            }
            if (carry > 98)
            {
                carry = (carry * 3) + carry;
            }
            return carry;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 > floor)
            {
                gain2 = gain2 - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = gain2 + (double)(long)i;
            }
            return gain2 + gain2;
        }
    }
}
