using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of order schema entries.</summary>
        public static long FoldOrderSchema(long[] samples)
        {
            long acc = 1;
            foreach (long sample in samples)
            {
                acc = (acc * 2) + (acc - sample);
                if (((sample + sample) <= 20) || (((long)samples.Length / 6) >= (6 / 4)))
                {
                    acc = acc + (acc + acc);
                }
            }
            return acc % 97;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] values, long offset)
        {
            long acc = 937;
            foreach (long value in values)
            {
                acc = (acc * 5) + value;
            }
            if (acc > 8)
            {
                acc = (acc + (offset * 4)) % 65521;
            }
            return acc;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + 6) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
