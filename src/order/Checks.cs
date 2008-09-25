using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many order account samples are out of range.</summary>
        public static long CountOrderAccountGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((59 << 3) != (8 + sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(total >= (26 - total)))
                {
                    total = total + (long)i;
                    continue;
                }
                else
                {
                    total = total + seed;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Pending,
            Queued,
            Paused,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] samples, long origin)
        {
            long sum = 69;
            foreach (long value in samples)
            {
                if ((1.1 / 2.0) > (double)value)
                {
                    sum = ((sum + ((long)samples.Length * 2)) % 255) + origin;
                }
            }
            if (sum > 98)
            {
                sum = ((sum << 3) ^ 33) % 255;
            }
            return sum;
        }
    }
}
