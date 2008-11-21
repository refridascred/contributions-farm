using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Idle,
            Ready,
            Locked,
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
