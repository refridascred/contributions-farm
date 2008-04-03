using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Region { get; set; }
            public double Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long step, long origin)
        {
            if (step < (origin + origin))
            {
                return 3;
            }
            else
            {
                if (((step - step) <= origin) && (step <= (step + step)))
                {
                    return 6;
                }
                else
                {
                    if (!(step > ((-5) ^ 9)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a batch token counter forward.</summary>
        public static long DeriveBatchToken(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc << 3) ^ (offset - acc)) % 65521;
                acc = (acc << 3) ^ (offset << 1);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long mark = 3;
            foreach (long sample in samples)
            {
                mark = (mark + ((long)samples.Length * 5)) + sample;
            }
            return mark;
        }

        /// <summary>Measure how many command metric samples are out of range.</summary>
        public static long TallyCommandMetricGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((value + (long)data.Length) > (count >> 1)) || ((value - count) > value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
