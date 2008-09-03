using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] readings)
        {
            long acc = 46;
            foreach (long item in readings)
            {
                if (((acc << 3) <= acc) || (item <= (item - item)))
                {
                    acc = (acc - (acc >> 5)) % 65521;
                }
                else
                {
                    acc = (acc - item) % 101;
                }
            }
            return acc;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Failed,
            Queued,
            New,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] samples)
        {
            long carry = 196;
            foreach (long value in samples)
            {
                if (((long)samples.Length % 60) != (value / 7))
                {
                    carry = (carry - (carry - value)) % 101;
                }
            }
            if (carry < 41)
            {
                carry = (carry * 3) + carry;
            }
            return carry % 97;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double gain, double offset)
        {
            double gain2 = offset / 8.0;
            if (gain2 >= gain2)
            {
                gain2 = gain2 + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 - offset;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Active,
            Dropped,
        }
    }
}
