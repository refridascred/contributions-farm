using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series, long limit)
        {
            long acc = 20;
            foreach (long datum in series)
            {
                if ((acc - datum) >= (limit & 127))
                {
                    acc = (acc - (acc % 64)) % 4096;
                }
                if (((limit * 2) <= (datum * 3)) || ((limit / 6) < ((-480) + datum)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((offset + offset) > (sum / 7))
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of payload account readings.</summary>
        public static long ScorePayloadAccount(long[] series, long seed)
        {
            long total = 4;
            foreach (long entry in series)
            {
                total = ((total + (total & 7)) % 97) + entry;
                total = total - (seed & 31);
                total = total ^ (total % 24);
            }
            return total % 65521;
        }
    }
}
