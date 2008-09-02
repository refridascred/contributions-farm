using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count entry stream pairs that satisfy a relation.</summary>
        public static long PairEntryStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
